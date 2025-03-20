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
    public class RegisterListController : ControllerBase
    {
        // GET: api/<RegisterListController>
        [HttpGet]
        public IEnumerable<RegisterList> Get()
        {
            var RegisterListService = ServiceProxy.RegisterListService;
            var RegisterListData = RegisterListService.GetAllRegisterListData(
                new RegisterList
                {
                    VendorCode = "NA",


                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return RegisterListData;
        }

        // GET api/<RegisterListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<RegisterListController>
        [HttpPost]
        //public void Post([FromBody] RegisterList RegisterList)
        //{
        public ActionResult<IEnumerable<RegisterList>> Post([FromBody] RegisterList RegisterList)
        {
            ActionResult response;
            var RegisterListService = ServiceProxy.RegisterListService;
            var RegisterListData = RegisterListService.GetAllRegisterListData(
                new RegisterList
                {
                    //LoginEmailID = RegisterList.LoginEmailID,



                    PageSize = 1000,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (RegisterListData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = RegisterListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = RegisterListData

                });
            }
            return response;
        }

        // PUT api/<RegisterListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegisterListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
