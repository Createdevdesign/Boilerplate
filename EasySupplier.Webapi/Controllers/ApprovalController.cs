using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Web.Helpers;

namespace BoilerSupplier.Webapi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalController : ControllerBase
    {
        // GET: api/<ApprovalController>
        [HttpGet]
        public void Get()
        {
            
        }

        // GET api/<ApprovalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<ApprovalController>
        [HttpPost]
        //public void Post([FromBody] Approval Approval)
        public ActionResult<IEnumerable<Approval>> Post([FromBody] Approval Approval)
        {
            ActionResult response;
            var ApprovalService = ServiceProxy.ApprovalService;
            var ApprovalData = ApprovalService.InsertApproval(
                new Approval
                {
                    VendorCode = Approval.VendorCode,
                    LoginEmailID = Approval.LoginEmailID,
                    
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (ApprovalData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = ApprovalData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = ApprovalData

                });
            }
            return response;

          

        }

        // PUT api/<ApprovalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApprovalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
