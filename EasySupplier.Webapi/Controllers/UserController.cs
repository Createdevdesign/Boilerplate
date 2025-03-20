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
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var UserService = ServiceProxy.UserService;
            var UserData = UserService.GetAllUserData(
                new User
                {
                    Id = 1,
                    UserRole=1,
                    UserName="NA",
                    MobileNo=1,
                    EmailId="NA",
                    Password="NA",
                    UserId="NA",
                    Active=true,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return UserData;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            var UserService = ServiceProxy.UserService;
            var UserData = UserService.GetAllUserData(
                new User
                {
                    Id = user.Id,
                    UserRole = user.UserRole,
                    UserName = user.UserName,
                    MobileNo = user.MobileNo,
                    EmailId = user.EmailId,
                    Password = user.Password,
                    UserId = user.UserId,
                    Active = user.Active,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
