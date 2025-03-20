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
    public class SectionCodeController : ControllerBase
    {
        // GET: api/<SectionCodeController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var SectionCodeService = ServiceProxy.SectionCodeService;
            var SectionCodeData = SectionCodeService.GetAllSectionCodeData(new SAPMaster
            {
                MANDT = 1,
                BUKRS = 1,
                FIWTIN_SECOG = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = SectionCodeData

            });

            return response;
        }

        // GET api/<SectionCodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<SectionCodeController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var SectionCodeService = ServiceProxy.SectionCodeService;
            var SectionCodeData = SectionCodeService.GetAllSectionCodeData(
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


            if (SectionCodeData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = SectionCodeData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = SectionCodeData

                });
            }

            return response;


        }

        // PUT api/<SectionCodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SectionCodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
