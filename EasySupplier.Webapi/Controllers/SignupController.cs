using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Web.Helpers;

namespace BoilerSupplier.Webapi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        // GET: api/<SignupController>
        [HttpGet]
        public IEnumerable<Signup> Get()
        {
            var SignupService = ServiceProxy.SignupService;
            var SignupData = SignupService.GetAllSignupData(
                new Signup
                {
                    FirstName = "NA",
                    LastName = "NA",
                    Designation = "NA",
                    MobileNo = "NA",
                    EmailAddress = "NA",
                    //OTP = "NA",
                    PreferredUserID = "NA",
                    Password ="NA" ,
                    
                    

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return SignupData;
        }

        // GET api/<SignupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<SignupController>
        [HttpPost]
        //public void Post([FromBody] Signup signup)
        public ActionResult<IEnumerable<Signup>> Post([FromBody] Signup signup)
        {
            ActionResult response; 
            //if (signup.Password == signup.ConfirmPassword)
            //{

            //}
            //string result = "no";
            //string passwordhash = Crypto.HashPassword(signup.Password.ToString());

            //bool result1 = clsCommon.IsPasswordValid(signup.Password.ToString(), clsCommon.PasswordRules.All, null);
            //if (!result1)
            //{
            //    result = Convert.ToString(result1.ToString());
            //}
            //else
            //{


            var SignupService = ServiceProxy.SignupService;

            //29-7-2021
            string pass = clsCommon.DecryptStringAES(signup.Password, "5824673190egvbAQ", "QAbvge0913764285");
            // now need to hash the password...
            signup.Password = clsCommon.GetMd5Hash(pass);

            var SignupData = SignupService.InsertSignupDetails(
                new Signup
                {
                    FirstName = signup.FirstName,
                    LastName = signup.LastName,
                    Designation = signup.Designation,
                    MobileNo = signup.MobileNo,
                    EmailAddress = signup.EmailAddress,
                        //OTP = signup.OTP,
                        PreferredUserID = signup.PreferredUserID,
                       // Password=signup.Password,
                        //ConfirmPassword=signup.ConfirmPassword,
                        //Password = Convert.ToByte(passwordhash.ToString()),
                        //ConfirmPassword = Convert.ToByte(passwordhash.ToString()),
                        //Password =Crypto.HashPassword(signup.Password.ToString()),
                  // ConfirmPassword = Crypto.HashPassword(signup.ConfirmPassword.ToString()),
                  Password=signup.Password,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (SignupData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = SignupData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = SignupData

                });
            }
            return response;

            //}

        }

        // PUT api/<SignupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SignupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
