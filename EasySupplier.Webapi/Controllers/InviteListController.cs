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
    public class InviteListController : ControllerBase
    {
        // GET: api/<InviteListController>
        [HttpGet]
        //public IEnumerable<Invite> Get()
        //{
            public ActionResult<IEnumerable<Invite>> Get()
            {
                ActionResult response;
                var InviteListService = ServiceProxy.InviteListService;
                var InviteListData = InviteListService.GetAllInviteListData(
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
                        ManpowerServices = "NA",
                        OtherServices = "NA",
                        ProductsServicesforFacilityManagement = "NA",
                        ReasonForContact = "NA",
                        CreatedDate=DateTime.Now,


                        PageSize = 10,
                        CurrentPage = 1,
                        MODE = "U"
                    });
                response = Ok(new
                {
                    status = 0,
                    data = InviteListData

                });

                return response;

            }

            // GET api/<InviteListController>/5
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
    var InviteListService = ServiceProxy.InviteListService;
            var InviteListData = InviteListService.GetAllInviteListData(
                new Invite
                {

                  //LoginEmailID=invite.LoginEmailID,
                  EmpRoleType=invite.EmpRoleType,
                    PageSize = 1000,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (InviteListData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = InviteListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = InviteListData

                });
            }

            return response;

        }

        // PUT api/<InviteListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InviteListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
