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
    public class SubmerchantController : ControllerBase
    {
        // GET: api/<SubmerchantController>
        [HttpGet]
        public IEnumerable<Submerchant> Get()
        {
            var SubmerchantService = ServiceProxy.SubmerchantService;
            var SubmerchantData = SubmerchantService.GetAllSubmerchantData(
                new Submerchant
                {
                    Id = 1,
                    HeadMerchantID="NA",
                    Submerchantid="NA",
                    Submerchantshortid="NA",
                    merchantid="NA",
                    tollname="NA",
                    Submerchanttype="NA",
                    pricemode="NA",
                    settlementtype="NA",
                    isactive=true,
                  
                    createdby="NA",
                    isdeleted="NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return SubmerchantData;
        }

        // GET api/<SubmerchantController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<SubmerchantController>
        [HttpPost]
        public void Post([FromBody] Submerchant submerchant)
        {
            var SubmerchantService = ServiceProxy.SubmerchantService;
            var SubmerchantData = SubmerchantService.GetAllSubmerchantData(
                new Submerchant
                {
                    Id = submerchant.Id,
                    HeadMerchantID = submerchant.HeadMerchantID,
                    Submerchantid = submerchant.Submerchantid,
                    Submerchantshortid = submerchant.Submerchantshortid,
                    merchantid = submerchant.merchantid,
                    tollname = submerchant.tollname,
                    Submerchanttype = submerchant.Submerchanttype,
                    pricemode = submerchant.pricemode,
                    settlementtype = submerchant.settlementtype,
                    isactive = submerchant.isactive,
                    isdeleted = submerchant.isdeleted,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<SubmerchantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubmerchantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
