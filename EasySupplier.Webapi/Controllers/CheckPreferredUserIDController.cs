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
    public class CheckPreferredUserIDController : ControllerBase
    {
        // GET: api/<CheckPreferredUserIDController>
        [HttpGet]
        public IEnumerable<Signup> Get()
        {
            var CheckPreferredUserIDService = ServiceProxy.CheckPreferredUserIDService;
            var CheckPreferredUserIDData = CheckPreferredUserIDService.CheckPreferredUserID(
                new Signup
                {
                    FirstName = "NA",
                    LastName = "NA",
                    Designation = "NA",
                    MobileNo = "NA",
                    EmailAddress = "NA",
                    //OTP = "NA",
                    PreferredUserID = "NA",
                    Password = "NA",



                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return CheckPreferredUserIDData;
        }

        // GET api/<CheckPreferredUserIDController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<CheckPreferredUserIDController>
        [HttpPost]
        //public void Post([FromBody] CheckPreferredUserID CheckPreferredUserID)
        public ActionResult<IEnumerable<Signup>> Post([FromBody] Signup Signup)
        {
            ActionResult response;
           


            var CheckPreferredUserIDService = ServiceProxy.CheckPreferredUserIDService;
            var CheckPreferredUserIDData = CheckPreferredUserIDService.CheckPreferredUserID(
                new Signup
                {
                    
                    PreferredUserID = Signup.PreferredUserID,
                   
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (CheckPreferredUserIDData!=null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = CheckPreferredUserIDData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = CheckPreferredUserIDData

                });
            }
            return response;




        
        }

        // PUT api/<CheckPreferredUserIDController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CheckPreferredUserIDController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
