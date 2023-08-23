using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeeManagement.Controllers
{
    [Route("api/[Controller]")]
    public class TokenController : Controller
    {
        private readonly IUser _IUser;
        private readonly IConfiguration _configuration;

        public TokenController(IConfiguration configuration, IUser user)
        {
            _IUser = user;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Post")]
        public async Task<IActionResult> Post(UserInfo _userInfo)
        {
            if (_userInfo != null && _userInfo.Email != null && _userInfo.PasswordHash != null)
            {
                var _user = _IUser.GetUser(_userInfo.Email, _userInfo.PasswordHash);

                if (_user != null)
                {
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Email",_user.Email)
                        };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddMinutes(10), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid Credentials");
                }
            }


            return BadRequest();
        }
    }
}
