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
    public class WithholdingTaxCodeExemptionController : ControllerBase
    {
        // GET: api/<WithholdingTaxCodeExemptionController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var WithholdingTaxCodeExemptionService = ServiceProxy.WithholdingTaxCodeExemptionService;
            var WithholdingTaxCodeExemptionData = WithholdingTaxCodeExemptionService.GetAllWithholdingTaxCodeExemptionData(new SAPMaster
            {
                MANDT = 1,
                WT_WITHCD = "NA",
                TEXT40 = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = WithholdingTaxCodeExemptionData

            });

            return response;
        }

        // GET api/<WithholdingTaxCodeExemptionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<WithholdingTaxCodeExemptionController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var WithholdingTaxCodeExemptionService = ServiceProxy.WithholdingTaxCodeExemptionService;
            var WithholdingTaxCodeExemptionData = WithholdingTaxCodeExemptionService.GetAllWithholdingTaxCodeExemptionData(
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


            if (WithholdingTaxCodeExemptionData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxCodeExemptionData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxCodeExemptionData

                });
            }

            return response;


        }

        // PUT api/<WithholdingTaxCodeExemptionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxCodeExemptionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
