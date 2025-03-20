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
    public class WIPApplicationListController : ControllerBase
    {
        // GET: api/<WIPApplicationListController>
        [HttpGet]
        public IEnumerable<WIPApplicationList> Get()
        {
            var WIPApplicationListService = ServiceProxy.WIPApplicationListService;
            var WIPApplicationListData = WIPApplicationListService.GetAllWIPApplicationListData(
                new WIPApplicationList
                {
                    VendorCode = "NA",
                    

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return WIPApplicationListData;
        }

        // GET api/<WIPApplicationListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<WIPApplicationListController>
        [HttpPost]
        //public void Post([FromBody] WIPApplicationList WIPApplicationList)
        //{
        public ActionResult<IEnumerable<WIPApplicationList>> Post([FromBody] WIPApplicationList WIPApplicationList)
        {
            ActionResult response;
            var WIPApplicationListService = ServiceProxy.WIPApplicationListService;
            var WIPApplicationListData = WIPApplicationListService.GetAllWIPApplicationListData(
                new WIPApplicationList
                {
                    //LoginEmailID = WIPApplicationList.LoginEmailID,
                    EmpRoleType=WIPApplicationList.EmpRoleType,
                    PageSize = 1000,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (WIPApplicationListData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WIPApplicationListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WIPApplicationListData

                });
            }

            return response;
        }

        // PUT api/<WIPApplicationListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WIPApplicationListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
