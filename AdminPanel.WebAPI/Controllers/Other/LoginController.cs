using AdminPanel.Guvenlik.AuthenticationKismi;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebAPI.Controllers.Other
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IAuthentication _authentication;
        public LoginController() : base()
        {
            _authentication = new Authentication();
        }

        [HttpPost()]
        public async Task<IActionResult> CreateEmailPassword(string email, string password)
        {
            //IActionResult result;

            var resource = await _authentication.CreateEmailPassword(email, password);

            //if (resource.Success)
            //{
            //    result = Ok(resource.Data);
            //}
            //else
            //    result = BadRequest(resource.Message);
            //return result;
            return dondur(resource);
        }

        [HttpPut()]
        [Authorize]
        public async Task<IActionResult> UpdatePassword(string email, string password)
        {
            var resource = await _authentication.UpdatePassword(email, password);
            return dondur(resource);
        }

        [HttpPut()]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Test()
        {
            return Ok("Geldi");
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAccessToken(string email, string password)
        {
            var resource = await _authentication.CreateAccessToken(email, password);
            return dondur(resource);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAccessTokenByRefreshToken(string email, string refreshToken)
        {
            var resource = await _authentication.CreateAccessTokenByRefreshToken(email, refreshToken);
            return dondur(resource);
        }

        [HttpDelete()]
        public async Task<IActionResult> RemoveRefreshToken(string email, string refreshToken)
        {
            var resource = await _authentication.RemoveRefreshToken(email, refreshToken);
            return dondur(resource);
        }

        private IActionResult dondur(dynamic resource)
        {
            IActionResult result;
            if (resource.Success)
            {
                result = Ok(resource.Data);
            }
            else
                result = BadRequest(resource.Message);

            return result;
        }
    }
}
