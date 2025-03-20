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
    public class SupplierDetailsController : ControllerBase
    {
        // GET: api/<SupplierDetailsController>
        [HttpGet]
        public ActionResult<IEnumerable<Vendor>> Get()
        {
            ActionResult response;
            var SupplierDetailsService = ServiceProxy.SupplierDetailsService;
            var SupplierDetailsData = SupplierDetailsService.GetAllSupplierDetailsData(new Vendor
            {
                
                PageSize = 10,
                CurrentPage = 1,
                MODE = "U"

            });
            response = Ok(new
            {
                status = 0,
                data = SupplierDetailsData

            });

            return response;
        }

        // GET api/<SupplierDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<SupplierDetailsController>
        [HttpPost]
        public ActionResult<IEnumerable<Vendor>> Post([FromBody] Vendor Vendor)
        {
            ActionResult response;
            var SupplierDetailsService = ServiceProxy.SupplierDetailsService;
            var SupplierDetailsData = SupplierDetailsService.GetAllSupplierDetailsData(
                new Vendor
                {


                    //VendorCode = Vendor.VendorCode,
                    LoginEmailID = Vendor.LoginEmailID,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });


            if (SupplierDetailsData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = SupplierDetailsData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = SupplierDetailsData

                });
            }

            return response;


        }

        // PUT api/<SupplierDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SupplierDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
