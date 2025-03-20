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
    public class TabVerifyAcceptDetailsController : ControllerBase
    {
        // GET: api/<TabVerifyAcceptDetailsController>
        [HttpGet]
        public string Get()
        {
            return "";
        }

        // GET api/<TabVerifyAcceptDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<TabVerifyAcceptDetailsController>
        [HttpPost]

        public ActionResult<IEnumerable<TabVerifyAccept>> Post([FromBody] TabVerifyAccept TabVerifyAccept)
        {
            ActionResult response;
            var TabVerifyAcceptDetailsService = ServiceProxy.TabVerifyAcceptDetailsService;
            var TabVerifyAcceptDetailsData = TabVerifyAcceptDetailsService.GetTabVerifyAcceptDetails(
                new TabVerifyAccept
                {

                    VendorCode = TabVerifyAccept.VendorCode,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (TabVerifyAcceptDetailsData!=null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = TabVerifyAcceptDetailsData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = TabVerifyAcceptDetailsData

                });
            }
            return response;
        }

        // PUT api/<TabVerifyAcceptDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TabVerifyAcceptDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
