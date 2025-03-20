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
    public class Email_FormatController : ControllerBase
    {
        // GET: api/<Email_FormatController>
        [HttpGet]
        public IEnumerable<Email_Format> Get()
        {
            var Email_FormatService = ServiceProxy.Email_FormatService;
            var Email_FormatData = Email_FormatService.GetAllEmail_FormatData(
                new Email_Format
                {
                    Relation_ID=1,
                    Format_Name="NA",
                    Format_Text="NA",
                    Module=1,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return Email_FormatData;
        }

        // GET api/<Email_FormatController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<Email_FormatController>
        [HttpPost]
        public void Post([FromBody] Email_Format email_Format)
        {
            var Email_FormatService = ServiceProxy.Email_FormatService;
            var Email_FormatData = Email_FormatService.GetAllEmail_FormatData(
                new Email_Format
                {                 
                    Format_Name = email_Format.Format_Name,
                    Format_Text = email_Format.Format_Text,
                    Module = email_Format.Module,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<Email_FormatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Email_FormatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
