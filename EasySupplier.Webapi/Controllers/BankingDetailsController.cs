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
    public class BankingDetailsController : ControllerBase
    {
        // GET: api/<BankingDetailsController>
        [HttpGet]
        public IEnumerable<BankingDetail> Get()
        {
            var BankingDetailsService = ServiceProxy.BankingDetailsService;
            var BankingDetailsData = BankingDetailsService.GetAllBankingDetailsData(
                new BankingDetail
                {
                    id = 1,
                    merchantid="NA",
                    accountnumber="NA",
                    acctype="NA",
                    ifsccode="NA",
                    bankid=1,
                    //Validfrom="Na",
                    //ValidTo,
                    Isactive=true,
                    //ChequeDetails=true,
                    Createdby="NA",
                    //CreatedDate,
                    Updatedby="NA",
                    //UpdatedDate="Na",
                    Entitytype="Na",                  

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return BankingDetailsData;
        }

        // GET api/<BankingDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<BankingDetailsController>
        [HttpPost]
        public void Post([FromBody] BankingDetail bankingDetail)
        {
            var BankingDetailsService = ServiceProxy.BankingDetailsService;
            var BankingDetailsData = BankingDetailsService.GetAllBankingDetailsData(
                new BankingDetail
                {
                   
                    merchantid = bankingDetail.merchantid,
                    accountnumber = bankingDetail.accountnumber,
                    acctype = bankingDetail.acctype,
                    ifsccode = bankingDetail.ifsccode,
                    bankid = bankingDetail.bankid,

                    Validfrom=bankingDetail.Validfrom,
                    ValidTo=bankingDetail.ValidTo,
                    Isactive = bankingDetail.Isactive,
                    ChequeDetails=bankingDetail.ChequeDetails,
                    Entitytype = bankingDetail.Entitytype,
                    
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            
        }

        // PUT api/<BankingDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BankingDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
