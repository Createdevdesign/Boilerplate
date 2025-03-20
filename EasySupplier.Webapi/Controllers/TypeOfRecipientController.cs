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
    public class TypeOfRecipientController : ControllerBase
    {
        // GET: api/<TypeOfRecipientController>
        [HttpGet]
        public ActionResult<IEnumerable<SAPMaster>> Get()
        {
            ActionResult response;
            var TypeOfRecipientService = ServiceProxy.TypeOfRecipientService;
            var TypeOfRecipientData = TypeOfRecipientService.GetAllTypeOfRecipientData(new SAPMaster
            {
                MANDT = 1,
                LAND1 = "NA",
                QSREC = "NA",

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = TypeOfRecipientData

            });

            return response;
        }

        // GET api/<TypeOfRecipientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<TypeOfRecipientController>
        [HttpPost]
        public ActionResult<IEnumerable<SAPMaster>> Post([FromBody] SAPMaster SAPMaster)
        {
            ActionResult response;
            var TypeOfRecipientService = ServiceProxy.TypeOfRecipientService;
            var TypeOfRecipientData = TypeOfRecipientService.GetAllTypeOfRecipientData(
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


            if (TypeOfRecipientData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = TypeOfRecipientData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = TypeOfRecipientData

                });
            }

            return response;


        }

        // PUT api/<TypeOfRecipientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TypeOfRecipientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
