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
    public class VendorDocumentController : ControllerBase
    {
        // GET: api/<VendorDocumentController>
        [HttpGet]
        public IEnumerable<VendorDocument> Get()
        {
            var VendorDocumentService = ServiceProxy.VendorDocumentService;
            var VendorDocumentData = VendorDocumentService.GetAllVendorDocumentData(
                new VendorDocument
                {
                    Document_Type = "NA",
                    Document_Name = "NA",
                    //Expiry_Date = null,
                    Document_Path = "NA",
            
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return VendorDocumentData;
        }

        // GET api/<VendorDocumentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<VendorDocumentController>
        [HttpPost]
        public void Post([FromBody] VendorDocument vendorDocument)
        {
            var VendorDocumentService = ServiceProxy.VendorDocumentService;
            var VendorDocumentData = VendorDocumentService.GetAllVendorDocumentData(
                new VendorDocument
                {
                    Document_Type = vendorDocument.Document_Type,
                    Document_Name = vendorDocument.Document_Name,
                    Expiry_Date = vendorDocument.Expiry_Date,
                    Document_Path = vendorDocument.Document_Path,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<VendorDocumentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendorDocumentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
