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
    public class RemarkDetailsController : ControllerBase
    {
        // GET: api/<RemarkDetailsController>
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // GET api/<RemarkController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<RemarkDetailsController>
        [HttpPost]
        //public void Post([FromBody] Remark Remark)
        public ActionResult<IEnumerable<Remark>> Post([FromBody] Remark remark)
        {
            ActionResult response;


            var RemarkDetailsService = ServiceProxy.RemarkDetailsService;
            var RemarkDetailsData = RemarkDetailsService.GetRemarkByFieldID(
                new Remark
                {
                    VendorCode = remark.VendorCode,
                    FieldId = remark.FieldId,
                   
                    PageSize = 200,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (RemarkDetailsData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = RemarkDetailsData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = RemarkDetailsData

                });
            }

            return response;



        }

        // PUT api/<RemarkDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RemarkDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
