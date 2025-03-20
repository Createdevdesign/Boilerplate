using BoilerSupplier.Business;
using BoilerSupplier.DataTransferObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using System.Web.Helpers;

using NLog.Web;

namespace BoilerSupplier.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    //public class LoginController : BaseController
    {
        //public LoginController(IConfiguration iconfig) : base(iconfig) { }
        private IConfiguration _config;
        protected readonly string Keys;
        protected readonly string IV;
        protected readonly string rechargetype;
        public LoginController(IConfiguration config)
        {
            _config = config;

            Keys = _config.GetSection("AESEncDec").GetSection("Key").Value;
            IV = _config.GetSection("AESEncDec").GetSection("iv").Value;
            //rechargetype = _config.GetSection("RechargeType").Value;
        }

        // POST api/<LoginController>
        //[HttpPost]
        //public IActionResult Login([FromBody] User loginCredentials)
        //{
        //    IActionResult response = Unauthorized();
        //    var user = AuthenticateUser(loginCredentials);
        //    //if(user != null)
        //    //{
        //    //    //var tokenSting = GenerateJsonWebToken(user);
        //    //    //response = Ok(new { token = tokenSting });

        //    //    //var tokenSting = GenerateJsonWebToken(user);
        //    //    response = Ok(new { token = "abcd" });
        //    //}
        //    if (Convert.ToString(user.Active) == "True")
        //    {
        //        //var tokenSting = GenerateJsonWebToken(user);
        //        response = Ok(new { token = "True" });
        //    }
        //    else
        //    {
        //        response = Ok(new { token = "False" });
        //    }
        //    return response;
        //}

        // POST api/<LoginController>
        [HttpPost]
        public ActionResult<IEnumerable<User>> Post([FromBody] User user)
        {
            var logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
            try
            {           
                ActionResult response;
                //30-8-2021
                string pass = clsCommon.DecryptStringAES(user.Password, Keys, IV);
                //string pass = clsCommon.DecryptStringAES(user.Password, "5824673190egvbAQ", "QAbvge0913764285");
                // now need to hash the password...
                user.Password = clsCommon.GetMd5Hash(pass);

                var loginService = ServiceProxy.LoginService;
                var LoginData = loginService.LoginCheck(
                    new User
                    {

                        EmailAddress = user.EmailAddress.ToString(),
                    //Password= Crypto.HashPassword(user.Password.ToString()),
                    Password = user.Password.ToString(),
                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "R"
                    });
                if (LoginData != null)
                {
                    if (LoginData.InviteID != null)
                    {
                        response = Ok(new
                        {
                            status = 0,
                            data = LoginData,
                            token = "abcd"
                        });
                        logger.Debug("Login Successfully!!");

                    }
                    else
                    {
                        response = Ok(new
                        {
                            status = 1,
                            data = LoginData,
                            token = ""
                        });
                        logger.Debug("Login fail!!");
                        
                    }
                }
                else
                {
                    response = Ok(new
                    {
                        status = 1,
                        data = LoginData,
                        token = ""
                    });
                    logger.Debug("Login fail!!");
                }
                return response;
            }
            catch (Exception exception)
            {
                logger.Error(exception, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }

        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private User AuthenticateUser(User loginCredentials)
        {
            //var loginService = ServiceProxy.LoginService;
            //var userRecord = loginService.FindUserByIdAndPassword(new User { UserId = loginCredentials.UserId, PasswordHash = loginCredentials.PasswordHash });
            //return userRecord;

            var loginService = ServiceProxy.LoginService;

            //string Password = Crypto.HashPassword(loginCredentials.Password);

            var userRecord = loginService.FindUserByIdAndPassword(
                new User { 
                    EmailAddress = loginCredentials.EmailAddress,
                    PreferredUserID=loginCredentials.PreferredUserID,

                    //please add code rohit sir hashpassword
                    Password = Crypto.HashPassword(loginCredentials.Password)
                });
            return userRecord;
        }

        private string GenerateJsonWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email ?? "itservies@esmpl.in"),
                new Claim("Password", userInfo.PasswordHash),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], 
                _config["Jwt:Issuer"],
                claims, 
                expires: DateTime.Now.AddMinutes(120), 
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
