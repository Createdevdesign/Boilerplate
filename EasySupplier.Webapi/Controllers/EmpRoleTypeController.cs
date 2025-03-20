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
    public class EmpRoleTypeController : ControllerBase
    {
        // GET: api/<EmpRoleTypeController>
        [HttpGet]
        public string Get()
        {
            return "";
        }

        // GET api/<EmpRoleTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<EmpRoleTypeController>
        [HttpPost]

        public ActionResult<IEnumerable<EmpRole>> Post([FromBody] EmpRole EmpRole)
        {
            ActionResult response;
            var EmpRoleTypeService = ServiceProxy.EmpRoleTypeService;
            var EmpRoleTypeData = EmpRoleTypeService.GetEmpRoleTypeData(
                new EmpRole
                {

                    EmpLoginEmailID = EmpRole.EmpLoginEmailID,
                    ADLogin=EmpRole.ADLogin,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (EmpRoleTypeData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = EmpRoleTypeData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = EmpRoleTypeData

                });
            }
            return response;
        }

        // PUT api/<EmpRoleTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpRoleTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
