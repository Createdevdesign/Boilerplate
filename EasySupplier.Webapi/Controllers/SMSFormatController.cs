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
    public class SMSFormatController : ControllerBase
    {
        // GET: api/<SMSFormatController>
        [HttpGet]
        public IEnumerable<SMSFormat> Get()
        {
            var sMSFormatService = ServiceProxy.SMSFormatService;
            var sMSFormatData = sMSFormatService.GetAllSMSFormatData(
                new SMSFormat
                {
                    Relation_ID = 1,
                    Format_Name = "NA",
                    Format_Text = "NA",
                    Module = 0,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return sMSFormatData;
        }

        // GET api/<SMSFormatController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<SMSFormatController>
        [HttpPost]
        public void Post([FromBody] SMSFormat sMSFormat)
        {
            var sMSFormatService = ServiceProxy.SMSFormatService;
            var sMSFormatData = sMSFormatService.GetAllSMSFormatData(
                new SMSFormat
                {
                    Relation_ID = sMSFormat.Relation_ID,
                    Format_Name = sMSFormat.Format_Name,
                    Format_Text = sMSFormat.Format_Text,
                    Module = sMSFormat.Module,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<SMSFormatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SMSFormatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
