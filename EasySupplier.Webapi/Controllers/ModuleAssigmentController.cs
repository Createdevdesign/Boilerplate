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
    public class ModuleAssigmentController : ControllerBase
    {
        // GET: api/<ModuleAssigmentController>
        [HttpGet]
        public IEnumerable<Module_Assigment> Get()
        {
            var moduleAssigmentService = ServiceProxy.ModuleAssigmentService;
            var moduleAssigmentData = moduleAssigmentService.GetAllModuleAssigmentData(
                new Module_Assigment
                {
                    Relation_ID = 1,
                    ACQ_ID = 0,
                    Module = 0,
                    Status = true,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return moduleAssigmentData;
        }

        // GET api/<ModuleAssigmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ModuleAssigmentController>
        [HttpPost]
        public void Post([FromBody] Module_Assigment module_Assigment)
        {
            var moduleAssigmentService = ServiceProxy.ModuleAssigmentService;
            var moduleAssigmentData = moduleAssigmentService.GetAllModuleAssigmentData(
                new Module_Assigment
                {
                    Relation_ID = module_Assigment.Relation_ID,
                    ACQ_ID = module_Assigment.ACQ_ID,
                    Module = module_Assigment.Module,
                    Status = module_Assigment.Status,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<ModuleAssigmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModuleAssigmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
