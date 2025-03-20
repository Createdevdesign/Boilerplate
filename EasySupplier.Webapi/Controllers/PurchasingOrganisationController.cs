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
    public class PurchasingOrganisationController : ControllerBase
    {
        // GET: api/<PurchasingOrganisationController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var PurchasingOrganisationService = ServiceProxy.PurchasingOrganisationService;
            var PurchasingOrganisationData = PurchasingOrganisationService.GetAllPurchasingOrganisationData(new SAPMaster
            {
                BUKRS = 1,
                EKORG = "NA",
                EKOTX = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = PurchasingOrganisationData

            });

            return response;
        }

        // GET api/<PurchasingOrganisationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<PurchasingOrganisationController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var PurchasingOrganisationService = ServiceProxy.PurchasingOrganisationService;
            var PurchasingOrganisationData = PurchasingOrganisationService.GetAllPurchasingOrganisationData(
                new SAPMaster
                {

                    ModeFlag = SAPMaster.ModeFlag,
                    BANKS = SAPMaster.BANKS,
                    EKORG = SAPMaster.EKORG,
                    QLAND1 = SAPMaster.QLAND1,
                    QLAND = SAPMaster.QLAND,
                    WITHT = SAPMaster.WITHT,
                    WITHTExemption = SAPMaster.WITHTExemption,
                    vendorcode = SAPMaster.vendorcode,

                    PageSize = 100,
                    CurrentPage = 1,
                    MODE = "R"
                });


            if (PurchasingOrganisationData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = PurchasingOrganisationData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = PurchasingOrganisationData

                });
            }

            return response;


        }

        // PUT api/<PurchasingOrganisationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PurchasingOrganisationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
