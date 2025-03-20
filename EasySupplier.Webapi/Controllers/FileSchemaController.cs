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
    public class FileSchemaController : ControllerBase
    {
        // GET: api/<FileSchemaController>
        [HttpGet]
        public IEnumerable<FileSchema> Get()
        {
            var fileSchemaService = ServiceProxy.FileSchemaService;
            var fileSchemaData = fileSchemaService.GetAllFileSchemaData(
                new FileSchema
                {
                    id = 1,
                    TransactionHeaderid = "NA",
                    FileID = "NA",
                    DestinationAgency = "NA",
                    Merchantid = "NA",
                    Submerchantid = "NA",
                    Filetypeid = "NA",
                    Filename = "NA",
                    Filestatus = 1,
                    Source = "NA",
                    Destination = "NA",
                    BackupPath = "NA",
                    NoofRecords = "NA",
                    SuccessfullProcessRecord = "NA",
                    UnsuccessfullRecord = "NA",
                    Remarks = "NA",
                                     
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return fileSchemaData;
        }

        // GET api/<FileSchemaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<FileSchemaController>
        [HttpPost]
        public void Post([FromBody] FileSchema fileSchema)
        {
            var fileSchemaService = ServiceProxy.FileSchemaService;
            var fileSchemaData = fileSchemaService.GetAllFileSchemaData(
                new FileSchema
                {
                    id = fileSchema.id,
                    TransactionHeaderid = fileSchema.TransactionHeaderid,
                    FileID = fileSchema.FileID,
                    DestinationAgency = fileSchema.DestinationAgency,
                    Merchantid = fileSchema.Merchantid,
                    
                    Submerchantid = fileSchema.Submerchantid,
                    Filetypeid = fileSchema.Filetypeid,
                    Filename = fileSchema.Filename,
                    Filestatus = fileSchema.Filestatus,
                    Source = fileSchema.Source,

                    Destination = fileSchema.Destination,                    
                    BackupPath = fileSchema.BackupPath,
                    NoofRecords = fileSchema.NoofRecords,
                    SuccessfullProcessRecord = fileSchema.SuccessfullProcessRecord,
                    UnsuccessfullRecord=fileSchema.UnsuccessfullRecord,
                    
                    Remarks = fileSchema.Remarks,
                 
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<FileSchemaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileSchemaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
