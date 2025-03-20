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
    public class SendBackController : ControllerBase
    {
        // GET: api/<SendBackController>
        [HttpGet]
        public void Get()
        {

        }

        // GET api/<SendBackController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<SendBackController>
        [HttpPost]
        //public void Post([FromBody] SendBack SendBack)
        public ActionResult<IEnumerable<SendBack>> Post([FromBody] SendBack SendBack)
        {
            ActionResult response;
            var SendBackService = ServiceProxy.SendBackService;
            var SendBackData = SendBackService.InsertSendBack(
                new SendBack
                {
                    VendorCode = SendBack.VendorCode,
                    LoginEmailID = SendBack.LoginEmailID,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (SendBackData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = SendBackData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = SendBackData

                });
            }
            return response;



        }

        // PUT api/<SendBackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SendBackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
