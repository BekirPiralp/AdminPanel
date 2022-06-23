using Microsoft.IdentityModel.Tokens;

namespace AdminPanel.WebAPI.Guvenlik.Token.Abstract
{
    public interface IImzalayici
    {
        SecurityKey GetSecurityKey(string SecurityKey);
    }
}
