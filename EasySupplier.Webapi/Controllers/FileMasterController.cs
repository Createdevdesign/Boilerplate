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
    public class FileMasterController : ControllerBase
    {
        // GET: api/<FileMasterController>
        [HttpGet]
        public IEnumerable<FileMaster> Get()
        {
            var FileMasterService = ServiceProxy.FileMasterService;
            var FileMasterData = FileMasterService.GetAllFileMasterData(
                new FileMaster
                {
                    Id = 1,
                   
                    InputFileName="NA",
                    Fileextension = "NA",
                    ProjectId=1,
                    isActive=true,
                    FileDirection = "NA",
                    Source = "NA",
                    Destination = "NA",
                    Description = "NA",
                    GenerationMethod=1,
                    IsOneWay = true,
                    ResponseFileName="NA",
                    ErrorSendingByEmail = true,
                    ErrorLogInSQL = true,
                    IsReprocessRequire = true,
                    ErrorLogTables="NA",
                    ErrorLogPage="NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return FileMasterData;
        }

        // GET api/<FileMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<FileMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FileMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
