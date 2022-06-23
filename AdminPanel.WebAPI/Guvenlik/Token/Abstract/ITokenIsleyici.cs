using AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi;
using AdminPanel.WebAPI.Guvenlik.Token.Objects;

namespace AdminPanel.WebAPI.Guvenlik.Token.Abstract
{
    public interface ITokenIsleyici
    {
        AccessToken CreateAccessToken(TokensMailPassword mailPassword);
        void RemoveRefreshToken(TokensTable token);
    }
}
