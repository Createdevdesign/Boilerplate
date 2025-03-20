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
    public class OperationalConfigrationController : ControllerBase
    {
        // GET: api/<ConfigrationController>
        [HttpGet]
        public IEnumerable<OperationalConfigrationMaster> Get()
        {
            var operationalConfigrationService = ServiceProxy.OperationalConfigrationService;
            var operationalConfigrationData = operationalConfigrationService.GetAllOperationalConfigrationData
                (new OperationalConfigrationMaster
                {
                    Configid = 1,
                    ConfigurationDescription = "NA",
                    ConfigurationName = "NA",
                    Configcategory = 0,
                    ConfigType = 0,
                    ConfigValueType = 0,
                    Remarks = "NA",
                    Submerchantname = "NA",
                    MerchantName = "NA",
                    PageSize = 10,
                    Configvalue = true,
                    AppDesc = 0,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return operationalConfigrationData;
        }

        // GET api/<OperationalConfigrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OperationalConfigrationController>
        [HttpPost]
        public void Post([FromBody] OperationalConfigrationMaster operationalConfigration)
        {
            var operationalConfigrationService = ServiceProxy.OperationalConfigrationService;
            var operationalConfigrationData = operationalConfigrationService.GetAllOperationalConfigrationData
                (new OperationalConfigrationMaster
                {
                    Configid = operationalConfigration.Configid,
                    ConfigurationDescription = operationalConfigration.ConfigurationDescription,
                    ConfigurationName = operationalConfigration.ConfigurationName,
                    Configcategory = operationalConfigration.Configcategory,
                    ConfigType = operationalConfigration.ConfigType,
                    ConfigValueType = operationalConfigration.ConfigValueType,
                    Remarks = operationalConfigration.Remarks,
                    Submerchantname = operationalConfigration.Submerchantname,
                    MerchantName = operationalConfigration.MerchantName,                   
                    Configvalue = operationalConfigration.Configvalue,
                    AppDesc = operationalConfigration.AppDesc,

                    PageSize = 10,                  
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<OperationalConfigrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OperationalConfigrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
