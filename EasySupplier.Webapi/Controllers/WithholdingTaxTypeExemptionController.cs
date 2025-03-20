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
    public class WithholdingTaxTypeExemptionController : ControllerBase
    {
        // GET: api/<WithholdingTaxTypeExemptionController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var WithholdingTaxTypeExemptionService = ServiceProxy.WithholdingTaxTypeExemptionService;
            var WithholdingTaxTypeExemptionData = WithholdingTaxTypeExemptionService.GetAllWithholdingTaxTypeExemptionData(new SAPMaster
            {
                MANDT = 1,
                WITHT = "NA",
                TEXT40 = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = WithholdingTaxTypeExemptionData

            });

            return response;
        }

        // GET api/<WithholdingTaxTypeExemptionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<WithholdingTaxTypeExemptionController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var WithholdingTaxTypeExemptionService = ServiceProxy.WithholdingTaxTypeExemptionService;
            var WithholdingTaxTypeExemptionData = WithholdingTaxTypeExemptionService.GetAllWithholdingTaxTypeExemptionData(
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

            if (WithholdingTaxTypeExemptionData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxTypeExemptionData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxTypeExemptionData

                });
            }

            return response;
        }

        // PUT api/<WithholdingTaxTypeExemptionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxTypeExemptionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
