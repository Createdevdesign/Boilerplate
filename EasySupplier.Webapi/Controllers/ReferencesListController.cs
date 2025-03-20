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
    public class ReferencesListController : ControllerBase
    {
        // GET: api/<ReferencesListController>
        [HttpGet]
        //public ActionResult<IEnumerable<Vendor>> Get()
        //{
        //    ActionResult response;
        //    var ReferencesListService = ServiceProxy.ReferencesListService;
        //    var ReferencesListData = ReferencesListService.GetAllReferencesListData(new Vendor
        //    {

        //        PageSize = 10,
        //        CurrentPage = 1,
        //        MODE = "U"

        //    });
        //    response = Ok(new
        //    {
        //        status = 0,
        //        data = ReferencesListData

        //    });

        //    return response;
        //}

        // GET api/<ReferencesListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<ReferencesListController>
        [HttpPost]
        public ActionResult<IEnumerable<Vendor>> Post([FromBody] Vendor Vendor)
        {
            ActionResult response;
            var ReferencesListService = ServiceProxy.ReferencesListService;
            var ReferencesListData = ReferencesListService.GetAllReferencesListData(
                new Vendor
                {


                    LoginEmailID = Vendor.LoginEmailID,

                    PageSize = 100,
                    CurrentPage = 1,
                    MODE = "R"
                });

            if (ReferencesListData != null)
            {

                response = Ok(new
                {
                    status = 0,
                    data = ReferencesListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = ReferencesListData

                });
            }

            return response;


        }

        // PUT api/<ReferencesListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReferencesListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
