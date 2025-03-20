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
    public class merchantController : ControllerBase
    {
        // GET: api/<merchantController>
        [HttpGet]
        public IEnumerable<merchant> Get()
        {
            var merchantService = ServiceProxy.merchantService;
            var merchantData = merchantService.GetAllmerchantData(
                new merchant
                {
                    id=1,
                    merchantid="NA",
                    merchantname="NA",
                    //merchantlogo="NA",
                    activactionkey="NA",
                   
                    createdby="NA",
                  
                    updatedby="NA",
                    isdeleted="NA",
                    headmerchantid="NA",
                    UserType="NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return merchantData;
        }

        // GET api/<merchantController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<merchantController>
        [HttpPost]
        public void Post([FromBody] merchant merchant)
        {
            var merchantService = ServiceProxy.merchantService;
            var merchantData = merchantService.GetAllmerchantData(
                new merchant
                {
                    id = merchant.id,
                    merchantid = merchant.merchantid,
                    merchantname = merchant.merchantname,
                    merchantlogo= merchant.merchantlogo,
                    activactionkey = merchant.activactionkey,                  
                    isdeleted = merchant.isdeleted,
                    headmerchantid = merchant.headmerchantid,
                    UserType = merchant.UserType,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<merchantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<merchantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
