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
    public class InviteController : ControllerBase
    {
        // GET: api/<InviteController>
        [HttpGet]
        public IEnumerable<Invite> Get()
        {
            var InviteService = ServiceProxy.InviteService;
            var InviteData = InviteService.GetAllInviteData(
                new Invite
                {
                    
                    YourName = "NA",
                    CompanyName = "NA",
                    EmailAddress = "NA",
                    PhoneNumber = "NA",
                    CompanyAddress = "NA",
                    ITEquipment = "NA",
                    Software = "NA",
                    Peripherals = "NA",
                    OfficeEquipment = "NA",
                    OfficeSupplies = "NA",
                    ManpowerServices  = "NA",
                    OtherServices  = "NA",
                    ProductsServicesforFacilityManagement = "NA",
                    ReasonForContact = "NA",



                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return InviteData;
        }

        // GET api/<InviteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<InviteController>
        [HttpPost]
        public ActionResult<IEnumerable<Invite>> Post([FromBody] Invite invite)
        {
            ActionResult response;
            var InviteService = ServiceProxy.InviteService;
            var InviteData = InviteService.GetAllInviteData(
                new Invite
                {

                    YourName = invite.YourName,
                    CompanyName = invite.CompanyName,
                    EmailAddress = invite.EmailAddress,
                    PhoneNumber = invite.PhoneNumber,
                    CompanyAddress = invite.CompanyAddress,
                    ITEquipment = invite.ITEquipment,
                    Software = invite.Software,
                    Peripherals = invite.Peripherals,
                    OfficeEquipment = invite.OfficeEquipment,
                    OfficeSupplies = invite.OfficeSupplies,
                    ManpowerServices = invite.ManpowerServices,
                    OtherServices = invite.OtherServices,
                    ProductsServicesforFacilityManagement = invite.ProductsServicesforFacilityManagement,
                    ReasonForContact = invite.ReasonForContact,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (InviteData.Count > 0)
            {

                response = Ok(new
                {
                    status = 0,
                    data = InviteData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = InviteData

                });
            }
            return response;

        }

        // PUT api/<InviteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InviteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
