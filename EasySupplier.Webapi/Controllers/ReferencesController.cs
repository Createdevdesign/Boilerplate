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
    public class ReferencesController : ControllerBase
    {
        // GET: api/<ReferencesController>
        [HttpGet]
        public IEnumerable<References> Get(References References)
        {
            var ReferencesService = ServiceProxy.ReferencesService;
            var ReferencesData = ReferencesService.GetAllReferencesData(
                new References
                {

                   
                    //References
                    RefCustomersName = References.RefCustomersName,
                    RefContactPerson = References.RefContactPerson,
                    RefDesignation = References.RefDesignation,
                    RefContactNo = References.RefContactNo,
                    RefEmailID = References.RefEmailID,
                    

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return ReferencesData;
        }

        // GET api/<ReferencesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ReferencesController>
        [HttpPost]
        public void Post([FromBody] References References)
        {
            var ReferencesService = ServiceProxy.ReferencesService;
            var ReferencesData = ReferencesService.GetAllReferencesData(
                new References
                {
                    
                    LoginEmailID = References.LoginEmailID,
                    
                    //References
                    RefCustomersName = References.RefCustomersName,
                    RefContactPerson = References.RefContactPerson,
                    RefDesignation = References.RefDesignation,
                    RefContactNo = References.RefContactNo,
                    RefEmailID = References.RefEmailID,
                    

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<ReferencesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReferencesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
