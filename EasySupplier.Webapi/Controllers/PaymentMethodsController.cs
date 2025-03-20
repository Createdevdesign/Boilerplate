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
    public class PaymentMethodsController : ControllerBase
    {
        // GET: api/<PaymentMethodsController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var PaymentMethodsService = ServiceProxy.PaymentMethodsService;
            var PaymentMethodsData = PaymentMethodsService.GetAllPaymentMethodsData(new SAPMaster
            {
                MANDT = 1,
                ZLSCH = "NA",
                TEXT2 = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = PaymentMethodsData

            });

            return response;
        }

        // GET api/<PaymentMethodsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<PaymentMethodsController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var PaymentMethodsService = ServiceProxy.PaymentMethodsService;
            var PaymentMethodsData = PaymentMethodsService.GetAllPaymentMethodsData(
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


            if (PaymentMethodsData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = PaymentMethodsData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = PaymentMethodsData

                });
            }

            return response;


        }

        // PUT api/<PaymentMethodsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentMethodsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
