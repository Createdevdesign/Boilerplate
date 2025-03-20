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
    public class InviteSupplierController : ControllerBase
    {
        // GET: api/<InviteSupplierController>
        [HttpGet]
        public IEnumerable<InviteSupplier> Get()
        {
            var InviteSupplierService = ServiceProxy.InviteSupplierService;
            var InviteSupplierData = InviteSupplierService.GetAllInviteSupplierData(
                new InviteSupplier
                {
                    PurOrgCode="NA",
                    FirstName = "NA",
                    LastName = "NA",
                    CompanyName = "NA",
                    ContactNo = "NA",
                    EmailAddress = "NA",
                    Invitedby="Na",



                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return InviteSupplierData;
        }

        // GET api/<InviteSupplierController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<InviteSupplierController>
        [HttpPost]
        //public void Post([FromBody] InviteSupplier InviteSupplier)
        public ActionResult<IEnumerable<InviteSupplier>> Post([FromBody] InviteSupplier InviteSupplier)
        {
            ActionResult response;
           

            var InviteSupplierService = ServiceProxy.InviteSupplierService;
            var InviteSupplierData = InviteSupplierService.GetAllInviteSupplierData(
                new InviteSupplier
                {
                    PurOrgCode=InviteSupplier.PurOrgCode,
                    FirstName = InviteSupplier.FirstName,
                    LastName = InviteSupplier.LastName,
                    CompanyName = InviteSupplier.CompanyName,
                    ContactNo = InviteSupplier.ContactNo,
                    EmailAddress = InviteSupplier.EmailAddress,
                    Invitedby=InviteSupplier.Invitedby,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if(InviteSupplierData.Count > 0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = InviteSupplierData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = InviteSupplierData

                });
            }

            return response;

          

        }

        // PUT api/<InviteSupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InviteSupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
