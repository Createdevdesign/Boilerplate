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
    public class FileFieldController : ControllerBase
    {
        // GET: api/<FileFieldController>
        [HttpGet]
        public IEnumerable<FileField> Get()
        {
            var FileFieldService = ServiceProxy.FileFieldService;
            var FileFieldData = FileFieldService.GetAllFileFieldData(
                new FileField
                {
                    Id = 1,
                 
                    FileId=1,
                    FieldName = "NA",
                    FieldDatatype = "NA",
                    FieldType = "NA",
                    Pattern = "NA",
                    IsMandatory=true,
                    FieldMaxLenth=1,
                    Fieldexpression = "NA",
                    Comments = "NA",
                    IsActive=true,
                    Ordering=1,
                    Label = "NA",
                    FileSectionType=1,
                   

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return FileFieldData;
        }

        // GET api/<FileFieldController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<FileFieldController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FileFieldController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileFieldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
