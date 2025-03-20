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
    public class VendorClassificationGSTController : ControllerBase
    {
        // GET: api/<VendorClassificationGSTController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var VendorClassificationGSTService = ServiceProxy.VendorClassificationGSTService;
            var VendorClassificationGSTData = VendorClassificationGSTService.GetAllVendorClassificationGSTData(new SAPMaster
            {
                BUKRS = 1,
                EKORG = "NA",
                EKOTX = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = VendorClassificationGSTData

            });

            return response;
        }

        // GET api/<VendorClassificationGSTController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<VendorClassificationGSTController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var VendorClassificationGSTService = ServiceProxy.VendorClassificationGSTService;
            var VendorClassificationGSTData = VendorClassificationGSTService.GetAllVendorClassificationGSTData(
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


            if (VendorClassificationGSTData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = VendorClassificationGSTData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = VendorClassificationGSTData

                });
            }
            return response;


        }

        // PUT api/<VendorClassificationGSTController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendorClassificationGSTController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
