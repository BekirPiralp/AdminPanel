using AdminPanel.WebAPI.Guvenlik.Token.Abstract;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AdminPanel.WebAPI.Guvenlik.Token.Concrete
{
    public class Imzalayici : IImzalayici
    {
        public SecurityKey GetSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
