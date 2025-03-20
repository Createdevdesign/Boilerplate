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
    public class PurchaseOrderController : ControllerBase
    {
        // GET: api/<PurchaseOrderController>
        [HttpGet]
        public IEnumerable<PurchaseOrder> Get()
        {
            var PurchaseOrderService = ServiceProxy.PurchaseOrderService;
            var PurchaseOrderData = PurchaseOrderService.GetAllPurchaseOrderData(
                new PurchaseOrder
                {
                   
                    POId = 1,
                    PONum = "NA",
                    POQtnId = 1,
                    POStatus = 1,                 
                    POOverallStatus = 1,
                    IsDeleted = true,
                    CreatedBy = 1,
                    //CreatedDtm="NA",
                    ModifyBy = 1,
                    //ModifyDtm="NA",                 
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return PurchaseOrderData;
        }

        // GET api/<PurchaseOrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<PurchaseOrderController>
        [HttpPost]
        //public void Post([FromBody] PurchaseOrder purchaseOrder)
        //{
        public ActionResult<IEnumerable<PurchaseOrder>> Post([FromBody] PurchaseOrder purchaseOrder)
        {
            ActionResult response;
            var PurchaseOrderService = ServiceProxy.PurchaseOrderService;
            var PurchaseOrderData = PurchaseOrderService.GetAllPurchaseOrderData(
                new PurchaseOrder
                {

                    POId = purchaseOrder.POId,
                    PONum = purchaseOrder.PONum,
                    POQtnId = purchaseOrder.POQtnId,
                    POStatus = purchaseOrder.POStatus,
                    POOverallStatus = purchaseOrder.POOverallStatus,
                    IsDeleted = purchaseOrder.IsDeleted,                             
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (PurchaseOrderData.Count > 0)
            {
                response = Ok(new
                {
                    status = 0,
                    data = PurchaseOrderData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = PurchaseOrderData

                });
            }
            return response;
        }

        // PUT api/<PurchaseOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PurchaseOrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
