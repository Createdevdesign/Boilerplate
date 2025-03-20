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
    public class SMSFormatMappingController : ControllerBase
    {
        // GET: api/<SMSFormatMappingController>
        [HttpGet]
        public IEnumerable<SMSFormatMapping> Get()
        {
            var SMSFormatMappingService = ServiceProxy.SMSFormatMappingService;
            var SMSFormatMappingData = SMSFormatMappingService.GetAllSMSFormatMappingData(
                new SMSFormatMapping
                {
                    Relation_ID=1,
                    ACQ_id=1,
                    Format=1,
                    Format_Text="NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return SMSFormatMappingData;
        }

        // GET api/<SMSFormatMappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<SMSFormatMappingController>
        [HttpPost]
        public void Post([FromBody] SMSFormatMapping sMSFormatMapping)
        {
            var SMSFormatMappingService = ServiceProxy.SMSFormatMappingService;
            var SMSFormatMappingData = SMSFormatMappingService.GetAllSMSFormatMappingData(
                new SMSFormatMapping
                {
                    Relation_ID = sMSFormatMapping.Relation_ID,
                    ACQ_id = sMSFormatMapping.ACQ_id,
                    Format = sMSFormatMapping.Format,
                    Format_Text = sMSFormatMapping.Format_Text,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<SMSFormatMappingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SMSFormatMappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
