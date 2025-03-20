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
    public class ReqStatusController : ControllerBase
    {
        // GET: api/<ReqStatusController>
        [HttpGet]
        public IEnumerable<ReqStatus> Get()
        {
            var ReqStatusService = ServiceProxy.ReqStatusService;
            var ReqStatusData = ReqStatusService.GetAllReqStatusData(
                new ReqStatus
                {
                    
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return ReqStatusData;
        }

        // GET api/<ReqStatusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ReqStatusController>
        [HttpPost]
        public void Post([FromBody] ReqStatus ReqStatus)
        {
            var ReqStatusService = ServiceProxy.ReqStatusService;
            var ReqStatusData = ReqStatusService.GetAllReqStatusData(
                new ReqStatus
                {

                    

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });

        }

        // PUT api/<ReqStatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReqStatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
