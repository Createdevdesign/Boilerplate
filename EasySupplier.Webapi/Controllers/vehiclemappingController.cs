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
    public class vehiclemappingController : ControllerBase
    {
        // GET: api/<vehiclemappingController>
        [HttpGet]
        public IEnumerable<vehiclemapping> Get()
        {
            var vehiclemappingService = ServiceProxy.vehiclemappingService;
            var vehiclemappingData = vehiclemappingService.GetAllvehiclemappingData(
                new vehiclemapping
                {
                    id=1,
                    submerchantid="NA",
                    Vehiclecategory="NA",
                    vehiclevalue=1,
                    isactive=true,
                    Updatedby="NA",
                    
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return vehiclemappingData;
        }

        // GET api/<vehiclemappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<vehiclemappingController>
        [HttpPost]
        public void Post([FromBody] vehiclemapping vehiclemapping)
        {
            var vehiclemappingService = ServiceProxy.vehiclemappingService;
            var vehiclemappingData = vehiclemappingService.GetAllvehiclemappingData(
                new vehiclemapping
                {
                    id = vehiclemapping.id,
                    submerchantid = vehiclemapping.submerchantid,
                    Vehiclecategory = vehiclemapping.Vehiclecategory,
                    vehiclevalue = vehiclemapping.vehiclevalue,
                    isactive = vehiclemapping.isactive,
                   
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<vehiclemappingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<vehiclemappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
