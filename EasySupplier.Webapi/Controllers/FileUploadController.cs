using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;



using System.IO;
using System.Net.Http.Headers;


namespace BoilerSupplier.Webapi.Controllers
{

    //[Route("api/[controller]")]
    //[ApiController]
    //public class FileUploadController : ControllerBase
    //{
    //    // GET: api/<FileUploadController>
    //    [HttpGet]
    //    public IEnumerable<FileUpload> Get()
    //    {
    //        var FileUploadService = ServiceProxy.FileUploadService;
    //        var FileUploadData = FileUploadService.GetAllFileUploadData(
    //            new FileUpload
    //            {


    //                PageSize = 10,
    //                CurrentPage = 1,
    //                MODE = "U"
    //            });
    //        return FileUploadData;
    //    }

    //    // GET api/<FileUploadController>/5
    //    [HttpGet("{id}")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }
    //    // POST api/<FileUploadController>
    //    [HttpPost]
    //    public void Post([FromBody] FileUpload fileUpload)
    //    {
    //        //var FileUploadService = ServiceProxy.FileUploadService;
    //        //var FileUploadData = FileUploadService.GetAllFileUploadData(
    //        //    new FileUpload
    //        //    {
    //        //        VendorCode=fileUpload.VendorCode,
    //        //        FileName=fileUpload.FileName,
    //        //        FileUploaded=fileUpload.FileUploaded,
    //        //        FileType=fileUpload.FileType,
    //        //        Size=fileUpload.Size,
    //        //        FilePath=fileUpload.FilePath,
    //        //        DocType =fileUpload.DocType,
    //        //        DocName=fileUpload.DocName,
    //        //        ExpiryDate = fileUpload.ExpiryDate,
    //        //        IsMandatory=fileUpload.IsMandatory,
    //        //        LoginEmailId=fileUpload.LoginEmailId,
    //        //        Flag=fileUpload.Flag,


    //        //        PageSize = 10,
    //        //        CurrentPage = 1,
    //        //        MODE = "I"
    //        //    });



    //    }

    //    // PUT api/<FileUploadController>/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] string value)
    //    {
    //    }

    //    // DELETE api/<FileUploadController>/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //    }
    //}



    
        [Route("api/[controller]")]
        [ApiController]
        public class FileUploadController : ControllerBase
        {
            [HttpPost, DisableRequestSizeLimit]
            public IActionResult Upload()
            {
                try
                {
               //var count= Request.Form.Files[0];
                
                    var file = Request.Form.Files[0];

                    var folderName = Path.Combine("StaticFiles", "Images");
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var fullPath = Path.Combine(pathToSave, fileName);
                        var dbPath = Path.Combine(folderName, fileName);

                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }

                        return Ok(new { status = 0, dbPath });
                    }
                    else
                    {
                        return BadRequest(new { status = 1 });
                    }
                
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex}");
                }
            }

            
        }
    
}
