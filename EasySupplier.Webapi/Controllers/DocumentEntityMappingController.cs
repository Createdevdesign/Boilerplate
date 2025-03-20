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
    public class DocumentEntityMappingController : ControllerBase
    {
        // GET: api/<DocumentEntityMappingController>
        [HttpGet]
        public IEnumerable<DocumentEntityMapping> Get()
        {
            var DocumentEntityMappingService = ServiceProxy.DocumentEntityMappingService;
            var DocumentEntityMappingData = DocumentEntityMappingService.GetAllDocumentEntityMappingData(
                new DocumentEntityMapping
                {
                    Relation_ID = 1,
                    entitycode = "NA",
                    Document =1,
                    Mandatory = true,
                    Updatedby = "NA",                   

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return DocumentEntityMappingData;
        }

        // GET api/<DocumentEntityMappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<DocumentEntityMappingController>
        [HttpPost]
        public void Post([FromBody] DocumentEntityMapping documentEntityMapping)
        {
            var DocumentEntityMappingService = ServiceProxy.DocumentEntityMappingService;
            var DocumentEntityMappingData = DocumentEntityMappingService.GetAllDocumentEntityMappingData(
                new DocumentEntityMapping
                {
                    Relation_ID = documentEntityMapping.Relation_ID,
                    entitycode = documentEntityMapping.entitycode,
                    Document = documentEntityMapping.Document,
                    Mandatory = documentEntityMapping.Mandatory,   
                    
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<DocumentEntityMappingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocumentEntityMappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
