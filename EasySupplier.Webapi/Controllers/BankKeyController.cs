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
    public class BankKeyController : ControllerBase
    {
        // GET: api/<BankKeyController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var BankKeyService = ServiceProxy.BankKeyService;
            var BankKeyData = BankKeyService.GetAllBankKeyData(new SAPMaster
            {
                MANDT = 1,
                BANKL = "NA",
                BANKA = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = BankKeyData

            });

            return response;
        }

        // GET api/<BankKeyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<BankKeyController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var BankKeyService = ServiceProxy.BankKeyService;
            var BankKeyData = BankKeyService.GetAllBankKeyData(
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



            response = Ok(new
            {
                status = 0,
                data = BankKeyData

            });

            return response;


        }

        // PUT api/<BankKeyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BankKeyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
