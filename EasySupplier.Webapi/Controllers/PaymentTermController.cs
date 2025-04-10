﻿using Microsoft.AspNetCore.Mvc;
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
    public class PaymentTermController : ControllerBase
    {
        // GET: api/<PaymentTermController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var PaymentTermService = ServiceProxy.PaymentTermService;
            var PaymentTermData = PaymentTermService.GetAllPaymentTermData(new SAPMaster
            {
                MANDT = 1,
                ZTERM = "NA",
                TEXT1 = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = PaymentTermData

            });

            return response;
        }

        // GET api/<PaymentTermController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<PaymentTermController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var PaymentTermService = ServiceProxy.PaymentTermService;
            var PaymentTermData = PaymentTermService.GetAllPaymentTermData(
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


            if (PaymentTermData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = PaymentTermData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = PaymentTermData

                });
            }
          

            return response;


        }

        // PUT api/<PaymentTermController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentTermController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
