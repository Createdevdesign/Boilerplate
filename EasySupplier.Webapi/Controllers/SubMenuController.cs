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
    public class SubMenuController : ControllerBase
    {
        // GET: api/<SubMenuController>
        [HttpGet]
        public IEnumerable<SubMenu> Get()
        {
            var subMenuService = ServiceProxy.SubMenuService;
            var subMenuData = subMenuService.GetAllSubMenuData(
                new SubMenu
                {
                    ID = 1,
                    varScreenTitle = "NA",
                    varPageName = "NA",
                    MainMenuId = 0,
                    Intorderno = 0,
                    ServicesId = 0,
                    AngularUrl = "NA",
                    ModifiedUser = "NA",
                    IsActive = true,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return subMenuData;
        }

        // GET api/<SubMenuController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<SubMenuController>
        [HttpPost]
        public void Post([FromBody] SubMenu subMenu)
        {
            var subMenuService = ServiceProxy.SubMenuService;
            var subMenuData = subMenuService.GetAllSubMenuData(
                new SubMenu
                {
                    ID = subMenu.ID,
                    varScreenTitle = subMenu.varScreenTitle,
                    varPageName = subMenu.varPageName,
                    MainMenuId = subMenu.MainMenuId,
                    Intorderno = subMenu.Intorderno,
                    ServicesId = subMenu.ServicesId,
                    AngularUrl = subMenu.AngularUrl,                    
                    IsActive = subMenu.IsActive,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<SubMenuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubMenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
