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
    public class RemarkController : ControllerBase
    {
        // GET: api/<RemarkController>
        [HttpGet]
        public IEnumerable<Remark> Get()
        {
            var RemarkService = ServiceProxy.RemarkService;
            var RemarkData = RemarkService.GetAllRemarkData(
                new Remark
                {
                    VendorCode = "NA",
                    FieldId = "NA",
                    Remarks = "NA",
                    



                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return RemarkData;
        }

        // GET api/<RemarkController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<RemarkController>
        [HttpPost]
        //public void Post([FromBody] Remark Remark)
        public ActionResult<IEnumerable<Remark>> Post([FromBody] Remark remark)
        {
            ActionResult response;


            var RemarkService = ServiceProxy.RemarkService;
            var RemarkData = RemarkService.GetAllRemarkData(
                new Remark
                {
                    VendorCode = remark.VendorCode,
                    FieldId = remark.FieldId,
                    Remarks = remark.Remarks,
                    CreatedBy=remark.CreatedBy,
                    
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (RemarkData.Count>0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = RemarkData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = RemarkData

                });
            }

            return response;



        }

        // PUT api/<RemarkController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RemarkController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
