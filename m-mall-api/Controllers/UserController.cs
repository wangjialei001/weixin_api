using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using m_mall_model.User;
using m_mall_model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace m_mall_api.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IConfiguration configuration;
        public UserController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [Route("sign/in")]
        [HttpPost]
        public async Task<WrapResult<object>> SignIn(RequestUserSginIn input)
        {
            var claims = new[]
            {
                    new Claim(JwtRegisteredClaimNames.Nbf,$"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}") ,
                    new Claim (JwtRegisteredClaimNames.Exp,$"{new DateTimeOffset(DateTime.Now.AddMinutes(30)).ToUnixTimeSeconds()}"),
                    new Claim(ClaimTypes.Name, input.UserName)
                };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Domain"],
                audience: configuration["Jwt:Domain"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);
            var data = new WrapResult<object> { Data = new { Token = new JwtSecurityTokenHandler().WriteToken(token) } };
            return await Task.FromResult(data);
        }
        [Route("sign/out")]
        [HttpPost]
        public async Task SignOut()
        {

        }
    }
}
