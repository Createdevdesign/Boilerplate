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
    public class ScreenRoleMappingController : ControllerBase
    {
        // GET: api/<ScreenRoleMappingController>
        [HttpGet]
        public IEnumerable<ScreenRoleMapping> Get()
        {
            var screenRoleMappingService = ServiceProxy.ScreenRoleMappingService;
            var screenRoleMappingData = screenRoleMappingService.GetAllScreenRoleMappingData(
                new ScreenRoleMapping
                {
                    ID = 1,
                    SubMenuId = 0,
                    RoleId = 0,
                    ServicesId = 0,
                    ModifiedUser = "NA",
                    IsActive = true,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return screenRoleMappingData;
        }

        // GET api/<ScreenRoleMappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ScreenRoleMappingController>
        [HttpPost]
        public void Post([FromBody] ScreenRoleMapping screenRoleMapping)
        {
            var screenRoleMappingService = ServiceProxy.ScreenRoleMappingService;
            var screenRoleMappingData = screenRoleMappingService.GetAllScreenRoleMappingData(
                new ScreenRoleMapping
                {
                    ID = screenRoleMapping.ID,
                    SubMenuId = screenRoleMapping.SubMenuId,
                    RoleId = screenRoleMapping.RoleId,
                    ServicesId = screenRoleMapping.ServicesId,                 
                    IsActive = screenRoleMapping.IsActive,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<ScreenRoleMappingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ScreenRoleMappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
