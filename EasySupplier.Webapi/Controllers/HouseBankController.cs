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
    public class HouseBankController : ControllerBase
    {
        // GET: api/<HouseBankController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var HouseBankService = ServiceProxy.HouseBankService;
            var HouseBankData = HouseBankService.GetAllHouseBankData(new SAPMaster
            {
                MANDT = 1,
                HBKID = "NA",
                BANKL = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = HouseBankData

            });

            return response;
        }

        // GET api/<HouseBankController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<HouseBankController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var HouseBankService = ServiceProxy.HouseBankService;
            var HouseBankData = HouseBankService.GetAllHouseBankData(
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


            if (HouseBankData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = HouseBankData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = HouseBankData

                });
            }

            return response;


        }

        // PUT api/<HouseBankController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HouseBankController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
