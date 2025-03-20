using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoilerSupplier.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        // GET: api/<LookupController>
        [HttpGet]
        public IEnumerable<Lookup> Get()
        {
            var lookupService = ServiceProxy.LookupService;
            var lookupMasterData = lookupService.GetAllLookupMasterData(new Lookup { OrganisationId = 1, CodeType = 7, CodeTypeDesc = "navneet", PageSize = 10, CodeSec = true, CurrentPage = 1,MODE="U"});
            return lookupMasterData;
        }

        // GET api/<LookupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LookupController>
        [HttpPost]
        public void Post([FromBody] Lookup lookup)
        {
            var lookupService = ServiceProxy.LookupService;
            var lookupMasterData = lookupService.GetAllLookupMasterData
                (
                new Lookup 
                { 
                OrganisationId = lookup.OrganisationId,
                CodeType = lookup.CodeType,
                CodeTypeDesc = lookup.CodeTypeDesc,
                CodeSec = lookup.CodeSec,

                PageSize = 10,                
                CurrentPage = 1,
                MODE = "I" 
            });

        }

        // PUT api/<LookupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LookupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
