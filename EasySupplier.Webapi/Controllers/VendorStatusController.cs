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
    public class VendorStatusController : ControllerBase
    {
        // GET: api/<VendorStatusController>
        [HttpGet]
        public IEnumerable<VendorStatus> Get()
        {
            var VendorStatusService = ServiceProxy.VendorStatusService;
            var VendorStatusData = VendorStatusService.GetAllVendorStatusData(
                new VendorStatus
                {

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return VendorStatusData;
        }

        // GET api/<VendorStatusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<VendorStatusController>
        [HttpPost]
        public void Post([FromBody] VendorStatus VendorStatus)
        {
            var VendorStatusService = ServiceProxy.VendorStatusService;
            var VendorStatusData = VendorStatusService.GetAllVendorStatusData(
                new VendorStatus
                {



                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });

        }

        // PUT api/<VendorStatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendorStatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
