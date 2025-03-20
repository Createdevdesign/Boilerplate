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
    public class InvoiceController : ControllerBase
    {
        // GET: api/<InvoiceController>
        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            var InvoiceService = ServiceProxy.InvoiceService;
            var InvoiceData = InvoiceService.GetAllInvoiceData(
                new Invoice
                {

                    VendorCode="NA",
                    Company="NA",
                    InvoiceNumber="NA",
                    InvoiceAccount="NA",
                    VendorName="NA",
                    VendorAccount="NA",
                    PurchaseOrderNumber="NA",
                    PostingDate="NA",
                    InvoiceDate="NA",
                    InvoiceDescription="NA",
                    Currency="NA",
                    Loged="NA",
                    ErrorMessage="NA",
                    Linereference="NA",

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return InvoiceData;
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<InvoiceController>
        [HttpPost]
        public void Post([FromBody] Invoice Invoice)
        {
            var InvoiceService = ServiceProxy.InvoiceService;
            var InvoiceData = InvoiceService.GetAllInvoiceData(
                new Invoice
                {

                    VendorCode = Invoice.VendorCode,
                    Company = Invoice.Company,
                    InvoiceNumber = Invoice.InvoiceNumber,
                    InvoiceAccount = Invoice.InvoiceAccount,
                    VendorName = Invoice.VendorName,
                    VendorAccount = Invoice.VendorName,
                    PurchaseOrderNumber = Invoice.PurchaseOrderNumber,
                    PostingDate = Invoice.PostingDate,
                    InvoiceDate = Invoice.InvoiceDate,
                    InvoiceDescription = Invoice.InvoiceDescription,
                    Currency = Invoice.Currency,
                    Loged = Invoice.Loged,
                    ErrorMessage = Invoice.ErrorMessage,
                    Linereference = Invoice.Linereference,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });

        }

        // PUT api/<InvoiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
