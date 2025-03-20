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
    public class TTLUseDetailController : ControllerBase
    {
        // GET: api/<TTLUseDetailController>
        [HttpGet]
        //public ActionResult<IEnumerable<TTLUse>> Get()
        //{
        //    ActionResult response;
        //    var TTLUseDetailService = ServiceProxy.TTLUseDetailService;
        //    var TTLUseDetailData = TTLUseDetailService.GetAllTTLUseDetailData(new TTLUse
        //    {

        //        PageSize = 10,
        //        CurrentPage = 1,
        //        MODE = "U"

        //    });
        //    response = Ok(new
        //    {
        //        status = 0,
        //        data = TTLUseDetailData

        //    });

        //    return response;
        //}

        // GET api/<TTLUseDetailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //POST api/<TTLUseDetailController>
        [HttpPost]
        public ActionResult<IEnumerable<TTLUse>> Post([FromBody] TTLUse TTLUse)
        {
            ActionResult response;
            var TTLUseDetailService = ServiceProxy.TTLUseDetailService;
            var TTLUseDetailData = TTLUseDetailService.GetAllTTLUseDetailData(
                new TTLUse
                {


                    VendorCode = TTLUse.VendorCode,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "R"
                });

            if (TTLUseDetailData != null)
            {

                response = Ok(new
                {
                    status = 0,
                    data = TTLUseDetailData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = TTLUseDetailData

                });
            }

            return response;


        }

        // PUT api/<TTLUseDetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TTLUseDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
