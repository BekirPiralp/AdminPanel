using AdminPanel.WebAPI.Guvenlik.Token.Abstract;
using AdminPanel.WebAPI.Guvenlik.Token.Concrete;

namespace AdminPanel.WebAPI.Guvenlik.Other
{
    public class GuvenlikOlusturucu
    {
        private static GuvenlikOlusturucu? _olusturucu;
        private static readonly Object _kilitNesnesi = new Object();

        public ITokenIsleyici TokenIsleyici { get; }
        public ITokenOpsiyonlari TokenOpsiyonlari { get; }
        public IImzalayici Imzalayici { get; }

        private GuvenlikOlusturucu()
        {
            Imzalayici = new Imzalayici();
            TokenOpsiyonlari = new TokenOpsiyonlari();
            TokenOpsiyonlariAta();

            TokenIsleyici = new TokenIsleyici(TokenOpsiyonlari, Imzalayici);

        }

        private void TokenOpsiyonlariAta()
        {
            TokenOpsiyonlari.Yayinci = "www.ben.com"; //"Ben Çalıyorum.";
            TokenOpsiyonlari.Dinleyici = "www.ben.com"; //"Ben Dinliyorum. ;)"; // alakası tyok // TODO alakası yok
            TokenOpsiyonlari.GuvenlikAnahtari = "Ağa yapma Beeeee .... - Biz yapmadık ki dostum...";
            TokenOpsiyonlari.AccessTokenSonKulanim = 10; // 10 dk sonra geçersiz
            TokenOpsiyonlari.RefreshTokenSonKullanim = 60; // 1 saat sonra geçersiz
            TokenOpsiyonlari.GecikmeSuresi = 0;

        }

        public static GuvenlikOlusturucu Olustur()
        {
            if (_olusturucu == null)
            {
                lock (_kilitNesnesi)
                {
                    if (_olusturucu == null)
                    {
                        _olusturucu = new GuvenlikOlusturucu();
                    }
                }
            }

            return _olusturucu;
        }
    }
}
