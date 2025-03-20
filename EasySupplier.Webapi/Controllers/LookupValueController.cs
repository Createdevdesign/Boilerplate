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
    public class LookupValueController : ControllerBase
    {
        // GET: api/<LookupValueController>
        [HttpGet]
        public ActionResult<IEnumerable<LookupValue>> Get()
        {
            ActionResult response;
            var lookupValueService = ServiceProxy.LookupValueService;
            var lookupValueData = lookupValueService.GetAllLookupValueData(new LookupValue
            {
                CodeType = 1,
                RefCode = "NA",
                CodeDesc = "NA",
                PageSize = 10,
                CurrentPage = 1,
                MODE = "R"

            });
            response = Ok(new
            {
                status = 0,
                data = lookupValueData

            });

            return response;
        }

        // GET api/<LookupValueController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LookupValueController>
        //[HttpPost]
        //public void Post([FromBody] LookupValue lookupValue)
        //{
        //    var lookupValueService = ServiceProxy.LookupValueService;
        //    var lookupValuerData = lookupValueService.GetAllLookupValueData(new LookupValue
        //    {
        //        ModeFlag = lookupValue.ModeFlag,
        //        LoginEmailId=lookupValue.LoginEmailId,
        //        Country=lookupValue.Country,
        //        PageSize = 10,
        //        CurrentPage = 1,
        //        MODE = "R"
        //    });
        //}

        //POST api/<LookupValueController>
        //[HttpPost]
        //public IEnumerable<LookupValue> Post([FromBody] LookupValue lookupValue)
        //{


        //    var LookupValueService = ServiceProxy.LookupValueService;
        //    var LookupValueData = LookupValueService.GetAllLookupValueData(
        //        new LookupValue
        //        {

        //            ModeFlag = lookupValue.ModeFlag,
        //            LoginEmailId = lookupValue.LoginEmailId,
        //            Country = lookupValue.Country,
        //            PageSize = 100,
        //            CurrentPage = 1,
        //            MODE = "R"
        //        });
        //    return LookupValueData;
        //}

        //Rohit sir Code
        //POST api/<LookupValueController>
        [HttpPost]
        public ActionResult<IEnumerable<LookupValue>> Post([FromBody] LookupValue lookupValue)
        {
            ActionResult response;
            var LookupValueService = ServiceProxy.LookupValueService;
            var LookupValueData = LookupValueService.GetAllLookupValueData(
                new LookupValue
                {

                    ModeFlag = lookupValue.ModeFlag,
                    LoginEmailId = lookupValue.LoginEmailId,
                    Country = lookupValue.Country,
                    PageSize = 100,
                    CurrentPage = 1,
                    MODE = "R"
                });


            if (LookupValueData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = LookupValueData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = LookupValueData

                });
            }

            return response;


        }

        // PUT api/<LookupValueController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LookupValueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
