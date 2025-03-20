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
    public class WithholdingTaxTypeController : ControllerBase
    {
        // GET: api/<WithholdingTaxTypeController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var WithholdingTaxTypeService = ServiceProxy.WithholdingTaxTypeService;
            var WithholdingTaxTypeData = WithholdingTaxTypeService.GetAllWithholdingTaxTypeData(new SAPMaster
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
                data = WithholdingTaxTypeData

            });

            return response;
        }

        // GET api/<WithholdingTaxTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<WithholdingTaxTypeController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var WithholdingTaxTypeService = ServiceProxy.WithholdingTaxTypeService;
            var WithholdingTaxTypeData = WithholdingTaxTypeService.GetAllWithholdingTaxTypeData(
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


            if (WithholdingTaxTypeData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxTypeData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxTypeData

                });
            }

            return response;


        }

        // PUT api/<WithholdingTaxTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
