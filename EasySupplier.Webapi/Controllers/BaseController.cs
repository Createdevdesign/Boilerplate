//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Mvc;

//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;
//using System;
//using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BoilerSupplier.Webapi.Controllers
{
    [EnableCors("ApiCorsPolicy")]
    public class BaseController : ControllerBase
    {
        protected IConfiguration _config;
        protected readonly string Keys;
        protected readonly string IV;
        protected readonly string rechargetype;

        public BaseController(IConfiguration config)
        {
            _config = config;
            Keys = _config.GetSection("AESEncDec").GetSection("Key").Value;
            IV = _config.GetSection("AESEncDec").GetSection("iv").Value;
            rechargetype = _config.GetSection("RechargeType").Value;

        }

        //protected bool ValidateCurrentToken(string token)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    try
        //    {
        //        tokenHandler.ValidateToken(token, new TokenValidationParameters
        //        {
        //            ValidateIssuerSigningKey = true,
        //            ValidateLifetime = true,
        //            ValidateAudience = true,
        //            ValidateIssuer = true,
        //            ValidIssuer = _config["Jwt:Issuer"],
        //            ValidAudience = _config["Jwt:Issuer"],
        //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]))
        //        }, out SecurityToken validatedToken);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        protected string GetClaim(string token, string claimType)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

            var stringClaimValue = securityToken.Claims.First(claim => claim.Type == claimType).Value;
            //string claimVal = AESEncrytDecry.DecryptStringAES(stringClaimValue,Keys,IV);
            //return clsCommon.AESEncrytDecry.DecryptStringAES(stringClaimValue, Keys, IV);
            return clsCommon.DecryptStringAES(stringClaimValue, Keys, IV);
        }

        private string GetUserIdFromAccessToken(string accessToken)
        {
            var tokenValidationParamters = new TokenValidationParameters
            {
                ValidateAudience = false, // You might need to validate this one depending on your case
                ValidateIssuer = false,
                ValidateActor = false,
                ValidateLifetime = false, // Do not validate lifetime here
                IssuerSigningKey =
                    new SymmetricSecurityKey(
                        Encoding.ASCII.GetBytes("<App Secret same as the one used in generating your JWT Token>")
                    )
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(accessToken, tokenValidationParamters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token!");
            }

            var userId = principal.FindFirst(ClaimTypes.Name)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                throw new SecurityTokenException($"Missing claim: {ClaimTypes.Name}!");
            }

            return userId;
        }
    }
}

