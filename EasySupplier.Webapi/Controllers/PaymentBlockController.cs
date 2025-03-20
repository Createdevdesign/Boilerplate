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
    public class PaymentBlockController : ControllerBase
    {
        // GET: api/<PaymentBlockController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var PaymentBlockService = ServiceProxy.PaymentBlockService;
            var PaymentBlockData = PaymentBlockService.GetAllPaymentBlockData(new SAPMaster
            {
                MANDT = 1,
                ZAHLS = "NA",
                TEXTL = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = PaymentBlockData

            });

            return response;
        }

        // GET api/<PaymentBlockController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<PaymentBlockController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var PaymentBlockService = ServiceProxy.PaymentBlockService;
            var PaymentBlockData = PaymentBlockService.GetAllPaymentBlockData(
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


            if (PaymentBlockData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = PaymentBlockData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = PaymentBlockData

                });
            }

            return response;


        }

        // PUT api/<PaymentBlockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentBlockController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
