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
    public class WithholdingTaxController : ControllerBase
    {
        // GET: api/<WithholdingTaxController>
        [HttpGet]
        public IEnumerable<WithholdingTax> Get()
        {
            var WithholdingTaxService = ServiceProxy.WithholdingTaxService;
            var WithholdingTaxData = WithholdingTaxService.GetAllWithholdingTaxData(
                new WithholdingTax
                {
                    VendorCode = "NA",
                    Ekorg = "NA",
                    WITHT = "NA",
                    WT_WITHCD="NA",
                    QSREC = "NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return WithholdingTaxData;
        }

        // GET api/<WithholdingTaxController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<WithholdingTaxController>
        [HttpPost]
        //public void Post([FromBody] WithholdingTax withholdingTax)
        //{
        public ActionResult<IEnumerable<WithholdingTax>> Post([FromBody] WithholdingTax withholdingTax)
        {
            ActionResult response;
            var WithholdingTaxService = ServiceProxy.WithholdingTaxService;
            var WithholdingTaxData = WithholdingTaxService.GetAllWithholdingTaxData(
                new WithholdingTax
                {
                    VendorCode = withholdingTax.VendorCode,
                    Ekorg = withholdingTax.Ekorg,
                    WITHT = withholdingTax.WITHT,
                    WT_WITHCD = withholdingTax.WT_WITHCD,
                    QSREC = withholdingTax.QSREC,
                    CreatedBy = withholdingTax.CreatedBy,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (WithholdingTaxData.Count > 0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxData

                });
            }

            return response;
        }

        // PUT api/<WithholdingTaxController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
