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
    public class NDAController : ControllerBase
    {
        // GET: api/<NDAController>
        [HttpGet]
        public ActionResult<IEnumerable<NDAApp>> Get()
        {
            ActionResult response;
            var NDAAppService = ServiceProxy.NDAService;
            var NDAData = NDAAppService.GetAllNDAData(new NDAApp
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
                data = NDAData

            });

            return response;
        }

        // GET api/<NDAController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<NDAController>
        [HttpPost]
        public ActionResult<IEnumerable<NDAApp>> Post([FromBody] NDAApp NDAApp)
        {
            ActionResult response;
            var NDAService = ServiceProxy.NDAService;
            var NDAData = NDAService.GetAllNDAData(
                new NDAApp
                {


                    LoginEmailID = NDAApp.LoginEmailID,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });


            if (NDAData.Count > 0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = NDAData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = NDAData

                });
            }

            return response;


        }

        // PUT api/<NDAController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NDAController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
