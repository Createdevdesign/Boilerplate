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
    public class WithholdingTaxExeListController : ControllerBase
    {
        // GET: api/<WithholdingTaxExeListController>
        [HttpGet]
        public IEnumerable<WithholdingTaxExe> Get()
        {
            var WithholdingTaxExeListService = ServiceProxy.WithholdingTaxExeListService;
            var WithholdingTaxExeListData = WithholdingTaxExeListService.GetAllWithholdingTaxExeListData(
                new WithholdingTaxExe
                {
                    VendorCode = "NA",
                    Ekorg = "NA",
                    SECCODE = "NA",
                    WT_EXNR = "NA",
                    WT_EXRT = 1,
                    WT_EXDF = DateTime.Now,
                    WT_EXDT = DateTime.Now,
                    WT_WTEXRS = "NA",
                    WITHT = "NA",
                    WT_WITHCD = "NA",
                    FIWTIN_EXEM_THR = 1,
                    WAERS = "NA",


                    PageSize = 200,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return WithholdingTaxExeListData;
        }

        // GET api/<WithholdingTaxExeListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<WithholdingTaxExeListController>
        [HttpPost]
        // public void Post([FromBody] WithholdingTaxExe WithholdingTaxExe)
        public ActionResult<IEnumerable<WithholdingTaxExe>> Post([FromBody] WithholdingTaxExe withholdingTaxExe)
        {
            ActionResult response;
            
                var WithholdingTaxExeListService = ServiceProxy.WithholdingTaxExeListService;
                var WithholdingTaxExeListData = WithholdingTaxExeListService.GetAllWithholdingTaxExeListData(
                    new WithholdingTaxExe
                    {
                        VendorCode = withholdingTaxExe.VendorCode,
                        Ekorg = withholdingTaxExe.Ekorg,


                        PageSize = 200,
                        CurrentPage = 1,
                        MODE = "R"
                    });
            if (WithholdingTaxExeListData != null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = WithholdingTaxExeListData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = WithholdingTaxExeListData

                });
            }

                return response;
            
        }

        // PUT api/<WithholdingTaxExeListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WithholdingTaxExeListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
