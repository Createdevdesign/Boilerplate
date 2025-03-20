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
    public class VendorSAPController : ControllerBase
    {
        // GET: api/<VendorSAPController>
        [HttpGet]
        public IEnumerable<VendorSAP> Get()
        {
            var VendorSAPService = ServiceProxy.VendorSAPService;
            var VendorSAPData = VendorSAPService.GetAllVendorSAPData(
                new VendorSAP
                {
                    Ekorg="NA",
                    Lifnr="NA",
                    Land1 = "NA",
                    Name1 = "NA",
                    Ort01 = "NA",
                    Pstlz = "NA",
                    Regio = "NA",
                    Sort1 = "NA",
                    Stras = "NA",
                    HouseNum1 = "NA",
                    Anred = "NA",
                    StrSuppl1 = "NA",
                    StrSuppl2 = "NA",
                    StrSuppl3 = "NA",
                    Stcd1 = "NA",
                    Telf2 = "NA",
                    Stcd3 = "NA",
                    Stceg = "NA",
                    Stenr = "NA",
                    Banks = "NA",
                    Bankl = "NA",
                    Bankn = "NA",
                    Bkont = "NA",
                    Bkref = "NA",
                    Koinh = "NA",
                    SmtpAddr1 = "NA",
                    SmtpAddr2 = "NA",
                    SmtpAddr3 = "NA",
                    SmtpAddr4 = "NA",
                    SmtpAddr5 = "NA",
                    Akont = "NA",
                    Mindk = "NA",
                    Cerdt = "NA",
                    Zterm = "NA",
                    Reprf = "NA",
                    Zsabe = "NA",
                    Waers = "NA",
                    Kalsk = "NA",
                    Webre = "NA",
                    Xnbwy = "NA",
                    Lebre = "NA",
                    ZtermComp = "NA",
                    VenClass = "NA",
                    J1tpbupl = "NA",
                    Name2 = "NA",
                    TelNumber = "NA",
                    FaxNumber = "NA",
                    Iban = "NA",
                    BankType = "NA",
                    Swift = "NA",
                    Zuawa = "NA",
                    Zwels = "NA",
                    Zahls = "NA",
                    Hbkid = "NA",
                    Qland = "NA",
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return VendorSAPData;
        }

        // GET api/<VendorSAPController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<VendorSAPController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // PUT api/<VendorSAPController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendorSAPController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
