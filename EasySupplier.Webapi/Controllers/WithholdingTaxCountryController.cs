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
    public class WithholdingTaxCountryController : ControllerBase
    {
        // GET: api/<WithholdingTaxCountryController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var WithholdingTaxCountryService = ServiceProxy.WithholdingTaxCountryService;
            var WithholdingTaxCountryData = WithholdingTaxCountryService.GetAllWithholdingTaxCountryData(new SAPMaster
            {
                MANDT = 1,
                QLAND = "NA",
                QLTXT = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = WithholdingTaxCountryData

            });

            return response;
        }

        // GET api/<WithholdingTaxCountryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<WithholdingTaxCountryController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var WithholdingTaxCountryService = ServiceProxy.WithholdingTaxCountryService;
            var WithholdingTaxCountryData = WithholdingTaxCountryService.GetAllWithholdingTaxCountryData(
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


            if (WithholdingTaxCountryData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxCountryData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxCountryData

                });
            }

            return response;


        }

        // PUT api/<WithholdingTaxCountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxCountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
