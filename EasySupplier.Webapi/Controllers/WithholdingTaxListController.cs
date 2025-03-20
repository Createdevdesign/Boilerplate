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
    public class WithholdingTaxListController : ControllerBase
    {
        // GET: api/<WithholdingTaxListController>
        [HttpGet]
        public IEnumerable<WithholdingTax> Get()
        {
            var WithholdingTaxListService = ServiceProxy.WithholdingTaxListService;
            var WithholdingTaxListData = WithholdingTaxListService.GetAllWithholdingTaxListData(
                new WithholdingTax
                {
                    VendorCode = "NA",
                    Ekorg = "NA",
                    WITHT = "NA",
                    WT_WITHCD = "NA",
                    QSREC = "NA",


                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return WithholdingTaxListData;
        }

        // GET api/<WithholdingTaxListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<WithholdingTaxListController>
        [HttpPost]
        //public void Post([FromBody] WithholdingTax withholdingTax)
        //{
        public ActionResult<IEnumerable<WithholdingTax>> Post([FromBody] WithholdingTax withholdingTax)
        {
            ActionResult response;
            var WithholdingTaxListService = ServiceProxy.WithholdingTaxListService;
            var WithholdingTaxListData = WithholdingTaxListService.GetAllWithholdingTaxListData(
                new WithholdingTax
                {
                    VendorCode = withholdingTax.VendorCode,
                    Ekorg = withholdingTax.Ekorg,
                   

                    PageSize = 200,
                    CurrentPage = 1,
                    MODE = "R"
                });
            if (WithholdingTaxListData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxListData

                });
            }

            return response;
        }

        // PUT api/<WithholdingTaxListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
