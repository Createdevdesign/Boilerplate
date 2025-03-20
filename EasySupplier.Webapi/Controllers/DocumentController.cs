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
    public class DocumentController : ControllerBase
    {
        // GET: api/<DocumentController>
        [HttpGet]
        public IEnumerable<Document> Get()
        {
            var DocumentService = ServiceProxy.DocumentService;
            var DocumentData = DocumentService.GetAllDocumentData(
                new Document
                {
                    //Relation_ID = 1,
                    //entitytype = 1,
                    //DocumentName ="NA",

                    countryID = 1,
                    Document_Name="NA",
                    Mandatory=true,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return DocumentData;
        }

        // GET api/<DocumentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<DocumentController>
        [HttpPost]
        public void Post([FromBody] Document document)
        {
            var DocumentService = ServiceProxy.DocumentService;
            var DocumentData = DocumentService.GetAllDocumentData(
                new Document
                {
                    
                    countryID = document.countryID,
                    Document_Name = document.Document_Name,
                    Mandatory = document.Mandatory,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            
        }

        // PUT api/<DocumentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocumentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


}
