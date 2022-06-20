using AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi;
using AdminPanel.Guvenlik.Token.Objects;
using AdminPanle.BusinessLayer.Other.Response;

namespace AdminPanle.BusinessLayer.Abstract.Other.AuthenticationKismi
{
    public interface IAuthentication
    {
        Task<ObjectResponse<TokensMailPassword>> CreateEmailPassword(string email, string password);

        Task<ObjectResponse<TokensMailPassword>> UpdatePassword(string email, string password);

        Task<ObjectResponse<AccessToken>> CreateAccessToken(string email, string password);

        Task<ObjectResponse<AccessToken>> CreateAccessTokenByRefreshToken(string email, string refreshToken);

        Task<ObjectResponse<AccessToken>> RemoveRefreshToken(string email, string refreshToken);


    }
}
