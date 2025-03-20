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
    public class RemarkListController : ControllerBase
    {
        // GET: api/<RemarkListController>
        [HttpGet]
        public IEnumerable<Remark> Get()
        {
            var RemarkListService = ServiceProxy.RemarkListService;
            var RemarkListData = RemarkListService.GetAllRemarkListData(
                new Remark
                {
                    VendorCode = "NA",
                    FieldId = "NA",
                    Remarks = "NA",
                    Flag = true,
                    CreatedBy="NA",
                    Status="NA",



                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                }); ;
            return RemarkListData;
        }

        // GET api/<RemarkController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<RemarkListController>
        [HttpPost]
        //public void Post([FromBody] Remark Remark)
        public ActionResult<IEnumerable<Remark>> Post([FromBody] Remark remark)
        {
            ActionResult response;


            var RemarkListService = ServiceProxy.RemarkListService;
            var RemarkListData = RemarkListService.GetAllRemarkListData(
                new Remark
                {
                    VendorCode = remark.VendorCode,
                    //FieldId = Remark.FieldId,
                    //Remarks = Remark.Remarks,

                    PageSize = 200,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (RemarkListData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = RemarkListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = RemarkListData

                });
            }

            return response;



        }

        // PUT api/<RemarkListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RemarkListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
