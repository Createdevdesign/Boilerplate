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
    public class AddressController : ControllerBase
    {
        // GET: api/<AddressController>
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            var AddressService = ServiceProxy.AddressService;
            var AddressData = AddressService.GetAllAddressData(
                new Address
                {
                    Id = 1,
                    AddressLine1="NA",
                    AddressLine2 = "NA",
                    TalukaId=1,
                    DistrictId=1,
                    StateId=1,
                    CountryId=1,
                    PostalCode = "NA",
                    //SpatialLocation = "NA",
                    UserCode = "NA",                  
                    ModifiedUser = "NA",
                    IsActive=true,
                    Entitytype = "NA",
                  
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return AddressData;
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] Address address)
        {
            var AddressService = ServiceProxy.AddressService;
            var AddressData = AddressService.GetAllAddressData(
                new Address
                {
                   
                    AddressLine1 = address.AddressLine1,
                    AddressLine2 = address.AddressLine2,
                    TalukaId = address.TalukaId,
                    DistrictId = address.DistrictId,
                    StateId = address.StateId,

                    CountryId = address.CountryId,
                    PostalCode = address.PostalCode,                  
                    UserCode = address.UserCode,
                    ModifiedUser = address.ModifiedUser,
                    IsActive = address.IsActive,

                    Entitytype = address.Entitytype,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
