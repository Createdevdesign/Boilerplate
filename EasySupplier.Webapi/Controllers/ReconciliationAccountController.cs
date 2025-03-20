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
    public class ReconciliationAccountController : ControllerBase
    {
        // GET: api/<ReconciliationAccountController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var ReconciliationAccountService = ServiceProxy.ReconciliationAccountService;
            var ReconciliationAccountData = ReconciliationAccountService.GetAllReconciliationAccountData(new SAPMaster
            {
                BUKRS = 1,
                SAKNR = "NA",
                TXT50 = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = ReconciliationAccountData

            });

            return response;
        }

        // GET api/<ReconciliationAccountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<ReconciliationAccountController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var ReconciliationAccountService = ServiceProxy.ReconciliationAccountService;
            var ReconciliationAccountData = ReconciliationAccountService.GetAllReconciliationAccountData(
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


            if (ReconciliationAccountData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = ReconciliationAccountData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = ReconciliationAccountData

                });
            }

            return response;


        }

        // PUT api/<ReconciliationAccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReconciliationAccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
