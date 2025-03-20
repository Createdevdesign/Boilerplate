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
    public class WithholdingTaxExeController : ControllerBase
    {
        // GET: api/<WithholdingTaxExeController>
        [HttpGet]
        public IEnumerable<WithholdingTaxExe> Get()
        {
            var WithholdingTaxExeService = ServiceProxy.WithholdingTaxExeService;
            var WithholdingTaxExeData = WithholdingTaxExeService.GetAllWithholdingTaxExeData(
                new WithholdingTaxExe
                {
                    VendorCode = "NA",
                    Ekorg = "NA",
                    SECCODE = "NA",
                    WT_EXNR = "NA",
                    WT_EXRT = 1,
                    //WT_EXDF = "NA",
                    //WT_EXDT = "NA",
                    WT_WTEXRS = "NA",
                    WITHT = "NA",
                    WT_WITHCD = "NA",
                    FIWTIN_EXEM_THR = 1,
                    WAERS = "NA",


                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return WithholdingTaxExeData;
        }

        // GET api/<WithholdingTaxExeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<WithholdingTaxExeController>
        [HttpPost]
        //public void Post([FromBody] WithholdingTaxExe withholdingTaxExe)
        public ActionResult<IEnumerable<WithholdingTaxExe>> Post([FromBody] WithholdingTaxExe withholdingTaxExe)
        {
            ActionResult response;

            var WithholdingTaxExeService = ServiceProxy.WithholdingTaxExeService;
            var WithholdingTaxExeData = WithholdingTaxExeService.GetAllWithholdingTaxExeData(
                new WithholdingTaxExe
                {
                    VendorCode = withholdingTaxExe.VendorCode,
                    Ekorg = withholdingTaxExe.Ekorg,
                    SECCODE = withholdingTaxExe.SECCODE,
                    WT_EXNR = withholdingTaxExe.WT_EXNR,
                    WT_EXRT = withholdingTaxExe.WT_EXRT,
                    WT_EXDF = withholdingTaxExe.WT_EXDF,
                    WT_EXDT = withholdingTaxExe.WT_EXDT,
                    WT_WTEXRS = withholdingTaxExe.WT_WTEXRS,
                    WITHT = withholdingTaxExe.WITHT,
                    WT_WITHCD = withholdingTaxExe.WT_WITHCD,
                    FIWTIN_EXEM_THR = withholdingTaxExe.FIWTIN_EXEM_THR,
                    WAERS = withholdingTaxExe.WAERS,
                    CreatedBy = withholdingTaxExe.CreatedBy,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (WithholdingTaxExeData.Count > 0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxExeData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxExeData

                });
            }

            return response;
        }

        // PUT api/<WithholdingTaxExeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxExeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
