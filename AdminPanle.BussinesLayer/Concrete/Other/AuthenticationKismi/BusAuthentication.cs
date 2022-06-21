using AdminPanel.EntityLayer.Abctract;
using AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi;
using AdminPanel.Guvenlik.Other;
using AdminPanel.Guvenlik.Token.Abstract;
using AdminPanel.Guvenlik.Token.Objects;
using AdminPanle.BusinessLayer.Abstract.Other.AuthenticationKismi;
using AdminPanle.BusinessLayer.Other;
using AdminPanle.BusinessLayer.Other.Extensions;
using AdminPanle.BusinessLayer.Other.Response;

namespace AdminPanle.BusinessLayer.Concrete.Other.AuthenticationKismi
{
    public class BusAuthentication : IBusAuthentication
    {
        ITokenIsleyici _tokenIsleyici;
        IBusTokensMailPassword _mailPassword;
        IBusTokensTable _refreshTokentable;
        ITokenOpsiyonlari _tokenOpsiyonlari;

        public BusAuthentication()
        {
            _mailPassword = BusOlusturucu.Olustur().TokensMailPassword;
            _refreshTokentable = BusOlusturucu.Olustur().TokensTable;
            
            _tokenIsleyici = GuvenlikOlusturucu.Olustur().TokenIsleyici;
            _tokenOpsiyonlari = GuvenlikOlusturucu.Olustur().TokenOpsiyonlari;
        }

        public async Task<ObjectResponse<AccessToken>> CreateAccessToken(string email, string password)
        {
            ObjectResponse<AccessToken> result ;
            try
            {
                var mailPasswordResponse = await _mailPassword.GetByEmailAndPassword(email, password);
                if (mailPasswordResponse.Success)
                {
                    if (!mailPasswordResponse.Data.silinmisMi())
                    {
                        var token = _tokenIsleyici.CreateAccessToken(mailPasswordResponse.Data);
                        if (token != null)
                        {
                            var refresAddResult = await _refreshTokentable.AddAsync(new TokensTable
                            {
                                mailPassword = mailPasswordResponse.Data,
                                refreshToken = token.RefreshToken,
                                refreshTokenDate = DateTime.Now.AddMinutes(_tokenOpsiyonlari.RefreshTokenSonKullanim)
                            });

                            if (refresAddResult)
                            {
                                result = new ObjectResponse<AccessToken>(token);
                            }
                            else
                                result = new ObjectResponse<AccessToken>("Refresh Token kaydedilirken hata oluştu");
                        }
                        else
                        {
                            result = new ObjectResponse<AccessToken>("Token üretilemedi");
                        }
                    }
                    else
                        result = new ObjectResponse<AccessToken>("Bu mail password silimiştir. Yetkisiz işlem yapmaya çalışıyorsunuz.");
                }
                else
                    result = new ObjectResponse<AccessToken>(mailPasswordResponse.Message);

            }
            catch (Exception ex)
            {
                result = new ObjectResponse<AccessToken>("Access token üretilirken hata oluştu. : "+ex.Message);
            }
            return result;
        }

        public async Task<ObjectResponse<AccessToken>> CreateAccessTokenByRefreshToken(string email, string refreshToken)
        {
            ObjectResponse<AccessToken> result;
            try
            {
                var refresTableResponse = await _refreshTokentable.GetByRefreshToken(refreshToken);

            
                if (refresTableResponse.Success)
                {
                    if (!refresTableResponse.Data.silinmisMi())
                    {
                        if (refresTableResponse.Data.refreshTokenDate >= DateTime.Now)
                        {
                            // olaki şifresi güncellendi ise bu sayede eski kayıtlar giriş yapmaz. Id ile getirseydim yapabilirdi...
                            var emailPaswordResource = await _mailPassword.GetByEmailAndPassword(
                                refresTableResponse.Data.mailPassword.mail, refresTableResponse.Data.mailPassword.password);

                            if (emailPaswordResource.Success)
                            {
                                /* Süresi dolmadan işlem yapıldığı için geçerliliği devre dışı bırakılıyor*/
                                _tokenIsleyici.RemoveRefreshToken(refresTableResponse.Data);
                                await _refreshTokentable.UpdateAsync(refresTableResponse.Data);
                                result = await this.CreateAccessToken
                                    (emailPaswordResource.Data.mail, emailPaswordResource.Data.password);
                            }
                            else
                            {
                                result = new ObjectResponse<AccessToken>(emailPaswordResource.Message);
                            }

                        }
                        else
                        {
                            await _refreshTokentable.DeleteAsync(refresTableResponse.Data); // süresi dolduğu için siliyoruz
                            result = new ObjectResponse<AccessToken>("Refresh tokenın süresi dolmuştur.");
                        }
                    }
                    else
                        result = new ObjectResponse<AccessToken>("Bu refresh token silimiştir.");
                }
                else
                    result = new ObjectResponse<AccessToken>(refresTableResponse.Message);
            }
            catch (Exception ex)
            {
                result = new ObjectResponse<AccessToken>("Refresh token a göre access toke nüretilirken hata oluştu");
            }

            return result;
        }

        public async Task<ObjectResponse<TokensMailPassword>> CreateEmailPassword(string email, string password)
        {
            ObjectResponse<TokensMailPassword> result;

            try
            {
                var mailPasswordResource = await _mailPassword.GetByEmail(email);
                // message tanımları tek bir merkeze alınacak
                if (!mailPasswordResource.Success && mailPasswordResource.Message.Equals("Sistemde kayıtlı değildir."))
                {
                    var addResult = await _mailPassword.AddByAsync(new TokensMailPassword { mail = email, password = password });
                    if (addResult.isIdNotEmpty())
                    {
                        result = new ObjectResponse<TokensMailPassword>(addResult);
                    }
                    else
                        result = new ObjectResponse<TokensMailPassword>("Obje oluşturulamadı");
                }
                else
                {
                    if (mailPasswordResource.Message.isNotEmpty())
                        result = mailPasswordResource;
                    else
                        result = new ObjectResponse<TokensMailPassword>("Bu emailde sistemde bir kayıt mevcuttur.");
                }
            }
            catch (Exception ex)
            {
                result = new ObjectResponse<TokensMailPassword>("Mail ve Password kadedilirken hata oluştu. :" + ex.Message);
            }

            return result;
        }

        public  async Task<ObjectResponse<TokensTable>> RemoveRefreshToken(string email, string refreshToken)
        {
            ObjectResponse<TokensTable> result;
            try
            {
                var refrehTokenResource = await _refreshTokentable.GetByRefreshToken(refreshToken);

                if (refrehTokenResource.Success)
                {
                    if (refrehTokenResource.Data.silinmisMi())
                    {
                        // silindiği için idrekt yolluyoruz
                        result = new ObjectResponse<TokensTable>(refrehTokenResource.Data);
                    }
                    else
                    {
                        if (refrehTokenResource.Data.gecerlilikDurumu)
                        {
                            _tokenIsleyici.RemoveRefreshToken(refrehTokenResource.Data);
                            var islemResult=await _refreshTokentable.UpdateAsync(refrehTokenResource.Data);
                            if (islemResult)
                            {
                                result = new ObjectResponse<TokensTable>(refrehTokenResource.Data);
                            }
                            else
                                result = new ObjectResponse<TokensTable>("Refresh tokenı geçersi kılmada" +
                                    "bilinmeyen bir hata oluştu");
                            
                        }
                        else
                        {
                            // geçerliliği devre dışı kaldığı için direkt yolluyoruz
                            result = new ObjectResponse<TokensTable>(refrehTokenResource.Data);
                        }
                    }
                }
                else
                    result = new ObjectResponse<TokensTable>("Kaldırmak istediğiniz refres token getirilemedi. \nDetay: " +
                        refrehTokenResource.Message);
            }
            catch (Exception ex)
            {
                result = new ObjectResponse<TokensTable>("Refresh token kaldırılırken hata oluştu. : "+ex.Message);
            }

            return result;
        }

        public async Task<ObjectResponse<TokensMailPassword>> UpdatePassword(string email, string password)
        {
            ObjectResponse<TokensMailPassword> result;
            try
            {
                var emailResource = await _mailPassword.GetByEmail(email);

                if (emailResource.Success)
                {
                    emailResource.Data.password = password;

                    await _mailPassword.UpdateAsync(emailResource.Data);

                    result = emailResource;
                }
                else
                    result = new ObjectResponse<TokensMailPassword>($"İlgili \"{email}\" emaile ait veri bulunamadı.");
            }
            catch (Exception ex)
            {
                result = new ObjectResponse<TokensMailPassword>("Şifre güncelleme esnasında hata oluştu");
            }
            return result;
        }
    }
}
