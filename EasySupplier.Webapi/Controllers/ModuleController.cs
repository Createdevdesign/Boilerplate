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
    public class ModuleController : ControllerBase
    {
        // GET: api/<ModuleController>
        [HttpGet]
        public IEnumerable<ModuleMaster> Get()
        {
            var moduleService = ServiceProxy.ModuleService;
            var moduleData = moduleService.GetAllModuleData(
                new ModuleMaster
                {
                    Id = 1,
                    ModuleName = "NA",
                    ServicesId = 0,
                    icon = "NA",
                    ModuleOrder = 0,
                    ModuleAssign = "NA",
                    ModifiedUser = "NA",
                    IsActive = true,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return moduleData;
        }

        // GET api/<ModuleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ModuleController>
        [HttpPost]
        public void Post([FromBody] ModuleMaster module)
        {
            var moduleService = ServiceProxy.ModuleService;
            var moduleData = moduleService.GetAllModuleData(
                new ModuleMaster
                {
                    Id = module.Id,
                    ModuleName = module.ModuleName,
                    ServicesId = module.ServicesId,
                    icon = module.icon,
                    ModuleOrder = module.ModuleOrder,
                    ModuleAssign = module.ModuleAssign,
                    ModifiedUser = module.ModifiedUser,
                    IsActive = module.IsActive,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<ModuleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModuleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
