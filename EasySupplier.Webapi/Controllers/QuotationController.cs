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
    public class QuotationController : ControllerBase
    {
        // GET: api/<QuotationController>
        [HttpGet]
        public IEnumerable<Quotation> Get()
        {
            var QuotationService = ServiceProxy.QuotationService;
            var QuotationData = QuotationService.GetAllQuotationData(
                new Quotation
                {
                    //QtnId = 1,
                    //QtnPindId = 1,
                    //QtnNum = "NA",
                    //QtnStatus = 1,
                    //QtnVndId = 1,
                    //QtnOrgId = 1,
                    //QtnOverallStatus = 1,
                    //IsDeleted = true,
                    //CreatedBy=1,
                    ////CreatedDtm="NA",
                    //ModifyBy=1,
                    ////ModifyDtm="NA",
                    //QtnFilenm = "NA",
                    //QtnFilenmSaved = "NA", 
                    ContactPerson = "Na",
                    //QuotationDate = ,
                    QtnNumber = 1,
                    Remarks = "Na",
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return QuotationData;
        }

        // GET api/<QuotationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<QuotationController>
        [HttpPost]
        //public void Post([FromBody] Quotation quotation)
        public ActionResult<IEnumerable<Quotation>> Post([FromBody] Quotation quotation)
        {
            ActionResult response;
            var QuotationService = ServiceProxy.QuotationService;
            var QuotationData = QuotationService.InsertQuotation(
                new Quotation
                {
                    //QtnId = quotation.QtnId,
                    //QtnPindId = quotation.QtnPindId,
                    //QtnNum = quotation.QtnNum,
                    //QtnStatus = quotation.QtnStatus,
                    //QtnVndId = quotation.QtnVndId,
                    //QtnOrgId = quotation.QtnOrgId,
                    //QtnOverallStatus = quotation.QtnOverallStatus,
                    //IsDeleted = quotation.IsDeleted,                    
                    //QtnFilenm = quotation.QtnFilenm,
                    //QtnFilenmSaved = quotation.QtnFilenmSaved,
                    LoginEmailID=quotation.LoginEmailID,
                    ContactPerson =quotation.ContactPerson,
                    QtnDate=quotation.QtnDate,
                    QtnNumber=quotation.QtnNumber,
                    Remarks=quotation.Remarks,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (QuotationData!=null)
            {
                response = Ok(new
                {
                    status = 0,
                    data = QuotationData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = QuotationData

                });
            }
            return response;
        }

        // PUT api/<QuotationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuotationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
