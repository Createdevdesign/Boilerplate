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
    public class TabfieldsController : ControllerBase
    {
        // GET: api/<TabfieldsController>
        [HttpGet]
        public IEnumerable<Tabfields> Get()
        {
            var TabfieldsService = ServiceProxy.TabfieldsService;
            var TabfieldsData = TabfieldsService.GetAllTabfieldsData(
                new Tabfields
                {
                   
                    RelationID = 1,
                    OrganisationID = 1,
                    TabID = 1,
                    FieldID = 1,
                    Label = "NA",
                    Required = true,
                    Placeholder = "NA",
                    Tooltip = "NA",
                    Status = true,
                    Enabled = true,
                    Ordering = 1,
                    ContainerCssClass = "NA",
                    Show = true,
                    Public = true,
                    Short = true,                  
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return TabfieldsData;
        }

        // GET api/<TabfieldsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<TabfieldsController>
        [HttpPost]
        public IEnumerable<Tabfields> Post([FromBody] Tabfields tabfields)
        {
            var TabfieldsService = ServiceProxy.TabfieldsService;
            var TabfieldsData = TabfieldsService.GetAllTabfieldsData(
                new Tabfields
                {

                    LoginEmailID=tabfields.LoginEmailID,
                    Token=tabfields.Token,
                    PageSize = 200,
                    CurrentPage = 1,
                    MODE = "R"
                });
            return TabfieldsData;


        }

        // PUT api/<TabfieldsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE api/<TabfieldsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
