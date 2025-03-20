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
    public class EmailFormatMappingController : ControllerBase
    {
        // GET: api/<EmailFormatMappingController>
        [HttpGet]
        public IEnumerable<EmailFormatMapping> Get()
        {
            var EmailFormatMappingService = ServiceProxy.EmailFormatMappingService;
            var EmailFormatMappingData = EmailFormatMappingService.GetAllEmailFormatMappingData(
                new EmailFormatMapping
                {
                    Relation_ID=1,
                    ACQ_id=1,
                    Format=1,
                    Format_Text="Na",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return EmailFormatMappingData;
        }

        // GET api/<EmailFormatMappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<EmailFormatMappingController>
        [HttpPost]
        public void Post([FromBody] EmailFormatMapping emailFormatMapping)
        {
            var EmailFormatMappingService = ServiceProxy.EmailFormatMappingService;
            var EmailFormatMappingData = EmailFormatMappingService.GetAllEmailFormatMappingData(
                new EmailFormatMapping
                {
                    
                    ACQ_id = emailFormatMapping.ACQ_id,
                    Format = emailFormatMapping.Format,
                    Format_Text = emailFormatMapping.Format_Text,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<EmailFormatMappingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmailFormatMappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
