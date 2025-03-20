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
    public class TabVerifyAcceptController : ControllerBase
    {
        // GET: api/<TabVerifyAcceptController>
        [HttpGet]
        public string Get()
        {
            return "";
        }

        // GET api/<TabVerifyAcceptController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<TabVerifyAcceptController>
        [HttpPost]

        public ActionResult<IEnumerable<TabVerifyAccept>> Post([FromBody] TabVerifyAccept TabVerifyAccept)
        {
            ActionResult response;
            var TabVerifyAcceptService = ServiceProxy.TabVerifyAcceptService;
            var TabVerifyAcceptData = TabVerifyAcceptService.InsertTabVerifyAccept(
                new TabVerifyAccept
                {
                   
                    VendorCode = TabVerifyAccept.VendorCode,
                    Info = TabVerifyAccept.Info,
                    Bank = TabVerifyAccept.Bank,
                    Financial = TabVerifyAccept.Financial,
                    Certificates = TabVerifyAccept.Certificates,
                    Reference = TabVerifyAccept.Reference,
                    Additional = TabVerifyAccept.Additional,
                    NDA = TabVerifyAccept.NDA,
                    //TCOC=TabVerifyAccept.TCOC,
                    Documents = TabVerifyAccept.Documents,
                    TTLUse=TabVerifyAccept.TTLUse,


                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (TabVerifyAcceptData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = TabVerifyAcceptData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = TabVerifyAcceptData

                });
            }
            return response;
        }

        // PUT api/<TabVerifyAcceptController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TabVerifyAcceptController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
