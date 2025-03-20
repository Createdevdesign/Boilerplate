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
    public class TTLUseController : ControllerBase
    {
        // GET: api/<TTLUseController>
        [HttpGet]
        public IEnumerable<TTLUse> Get()
        {
            var TTLUseService = ServiceProxy.TTLUseService;
            var TTLUseData = TTLUseService.GetAllTTLUseData(
                new TTLUse
                {
                    EKORG="NA",BANKL = "NA",
                    BKONT = "NA",
                    BVTYP = "NA",
                    SWIFT = "NA",
                    AKONT = "NA",
                    ZTERM = "NA",
                    ZWELS = "NA",
                    ZAHLS = "NA",
                    HBKID = "NA",
                    KALSK = "NA",
                    ZTERMComp = "NA",
                    IBAN = "NA",
                    J_1TPBUPL = "NA",
                    // CERDT = "NA",
                    QLAND = "NA",
                    VEN_CLASS = "NA",
                    REPRF = "NA",
                    WEBRE = "NA",
                    XNBWY = "NA",
                    LEBRE = "NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return TTLUseData;
        }

        // GET api/<TTLUseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<TTLUseController>
        [HttpPost]
        //public void Post([FromBody] TTLUse tTLUse)
        //{
        public ActionResult<IEnumerable<TTLUse>> Post([FromBody] TTLUse tTLUse)
        {
            ActionResult response;
            var TTLUseService = ServiceProxy.TTLUseService;
            var TTLUseData = TTLUseService.GetAllTTLUseData(
                new TTLUse
                {
                    VendorCode=tTLUse.VendorCode,
                    EKORG = tTLUse.EKORG,
                    BANKL = tTLUse.BANKL,
                    BKONT = tTLUse.BKONT,
                    BVTYP = tTLUse.BVTYP,
                    
                    SWIFT = tTLUse.SWIFT,
                    AKONT = tTLUse.AKONT,
                    ZTERM = tTLUse.ZTERM,
                    ZWELS = tTLUse.ZWELS,
                    ZAHLS = tTLUse.ZAHLS,
                    
                    HBKID = tTLUse.HBKID,
                    KALSK = tTLUse.KALSK,
                    ZTERMComp = tTLUse.ZTERMComp,
                    IBAN = tTLUse.IBAN,
                    J_1TPBUPL = tTLUse.J_1TPBUPL,
                    
                    CERDT = tTLUse.CERDT,
                    QLAND = tTLUse.QLAND,
                    VEN_CLASS = tTLUse.VEN_CLASS,

                    REPRF = tTLUse.REPRF,
                    WEBRE = tTLUse.WEBRE,
                   
                    XNBWY = tTLUse.XNBWY,
                    LEBRE = tTLUse.LEBRE,

                    CreatedBy= tTLUse.CreatedBy,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (TTLUseData.Count>0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = TTLUseData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = TTLUseData

                });
            }

            return response;
        }

        // PUT api/<TTLUseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TTLUseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
