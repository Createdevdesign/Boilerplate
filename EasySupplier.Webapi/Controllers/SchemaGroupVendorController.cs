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
    public class SchemaGroupVendorController : ControllerBase
    {
        // GET: api/<SchemaGroupVendorController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var SchemaGroupVendorService = ServiceProxy.SchemaGroupVendorService;
            var SchemaGroupVendorData = SchemaGroupVendorService.GetAllSchemaGroupVendorData(new SAPMaster
            {
                MANDT = 1,
                KALSK = "NA",
                KALSB = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = SchemaGroupVendorData

            });

            return response;
        }

        // GET api/<SchemaGroupVendorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<SchemaGroupVendorController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var SchemaGroupVendorService = ServiceProxy.SchemaGroupVendorService;
            var SchemaGroupVendorData = SchemaGroupVendorService.GetAllSchemaGroupVendorData(
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


            if (SchemaGroupVendorData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = SchemaGroupVendorData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = SchemaGroupVendorData

                });
            }

            return response;


        }

        // PUT api/<SchemaGroupVendorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SchemaGroupVendorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
