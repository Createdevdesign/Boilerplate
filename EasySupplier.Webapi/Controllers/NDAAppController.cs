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
    public class NDAAppController : ControllerBase
    {
        // GET: api/<NDAAppController>
        [HttpGet]
        public ActionResult<IEnumerable<NDAApp>> Get()
        {
            ActionResult response;
            var NDAAppService = ServiceProxy.NDAAppService;
            var NDAAppData = NDAAppService.GetAllNDAAppData(new NDAApp
            {
               VendorCode="NA",
                EstablishmentName = "NA",
                OfficeAddress = "NA",
                Name = "NA",
                Designation = "NA",
                PurchasingOrgName = "NA",
                PurchasingOrgCode = "NA",
                BankCountry = "NA",
                MinorityIndicatorDate = DateTime.Now,

                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = NDAAppData

            });

            return response;
        }

        // GET api/<NDAAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<NDAAppController>
        [HttpPost]
        public ActionResult<IEnumerable<NDAApp>> Post([FromBody] NDAApp NDAApp)
        {
            ActionResult response;
            var NDAAppService = ServiceProxy.NDAAppService;
            var NDAAppData = NDAAppService.GetAllNDAAppData(
                new NDAApp
                {


                    VendorCode = NDAApp.VendorCode,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });


            if (NDAAppData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = NDAAppData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = NDAAppData

                });
            }

            return response;


        }

        // PUT api/<NDAAppController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NDAAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
