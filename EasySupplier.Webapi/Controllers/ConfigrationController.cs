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
    public class ConfigrationController : ControllerBase
    {
        // GET: api/<ConfigrationController>
        [HttpGet]
        public IEnumerable<ConfigrationMaster> Get()
        {
            var configrationService = ServiceProxy.ConfigrationService;
            var configrationData = configrationService.GetAllConfigrationData
                (new ConfigrationMaster
                {
                    Configid = 1,
                    ConfigurationDescription = "NA",
                    ConfigurationName = "NA",
                    Configcategory = 0,
                    ConfigType = 0,
                    ConfigValueType = 0,
                    Remarks = "NA",                   
                    Configvalue = true,
                    AppDesc = 0,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return configrationData;
        }

        // GET api/<ConfigrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConfigrationController>
        [HttpPost]
        public void Post([FromBody] ConfigrationMaster configration)
        {
            var configrationService = ServiceProxy.ConfigrationService;
            var configrationData = configrationService.GetAllConfigrationData
                (new ConfigrationMaster
                {
                    Configid = configration.Configid,
                    ConfigurationDescription = configration.ConfigurationDescription,
                    ConfigurationName = configration.ConfigurationName,
                    Configcategory = configration.Configcategory,
                    ConfigType = configration.ConfigType,
                   
                    ConfigValueType = configration.ConfigValueType,
                    Remarks = configration.Remarks,
                    Configvalue = configration.Configvalue,
                    AppDesc = configration.AppDesc,
                    
                    PageSize = 10,                   
                    CurrentPage = 1,
                    MODE = "I"
                });
            
        }

        // PUT api/<ConfigrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConfigrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
