using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;


namespace BoilerSupplier.Webapi.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        // GET: api/<ContactDetailsController>
        [HttpGet]
        public IEnumerable<ContactDetail> Get()
        {
            var ContactDetailsService = ServiceProxy.ContactDetailsService;
            var ContactDetailsData = ContactDetailsService.GetAllContactDetailsData(
                new ContactDetail
                {
                    Id = 1,
                    PhoneNumber=1,
                    PhoneNumberType="NA",
                    EmailAddress="NA",                   
                    UserCode = "NA",
                    ModifiedUser = "NA",
                    IsActive = true,
                    Entitytype = "NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return ContactDetailsData;
        }

        // GET api/<ContactDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ContactDetailsController>
        [HttpPost]
        public void Post([FromBody] ContactDetail contactDetail)
        {
            var ContactDetailsService = ServiceProxy.ContactDetailsService;
            var ContactDetailsData = ContactDetailsService.GetAllContactDetailsData(
                new ContactDetail
                {
                    
                    PhoneNumber = contactDetail.PhoneNumber,
                    PhoneNumberType = contactDetail.PhoneNumberType,
                    EmailAddress = contactDetail.EmailAddress,
                    UserCode = contactDetail.UserCode,                                    
                    IsActive = contactDetail.IsActive,

                    Entitytype = contactDetail.Entitytype,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });
           
        }

        // PUT api/<ContactDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
