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
    public class MainMenuController : ControllerBase
    {
        // GET: api/<MainMenuController>
        [HttpGet]
        public IEnumerable<MainMenu> Get()
        {
            var mainMenuService = ServiceProxy.MainMenuService;
            var mainMenuData = mainMenuService.GetAllMainMenuData(
                new MainMenu
                {
                    Id = 1,
                    MainMenuName = "NA",
                    MenuOrder = 0,
                    ServicesID = 0,
                    ModuleName = "NA",
                    ModuleId = "NA",
                    icon = "NA",
                    ModifiedUser = "NA",
                    IsActive = true,
                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "U"
                });
            return mainMenuData;
        }

        // GET api/<MainMenuController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<MainMenuController>
        [HttpPost]
        public void Post([FromBody]  MainMenu mainMenu)
        {
            var mainMenuService = ServiceProxy.MainMenuService;
            var mainMenuData = mainMenuService.GetAllMainMenuData(
                new MainMenu
                {
                    Id = mainMenu.Id,
                    MainMenuName = mainMenu.MainMenuName,
                    MenuOrder = mainMenu.MenuOrder,
                    ServicesID = mainMenu.ServicesID,
                    ModuleName = mainMenu.ModuleName,
                    
                    ModuleId = mainMenu.ModuleId,
                    icon = mainMenu.icon,
                    ModifiedUser = mainMenu.ModifiedUser,
                    IsActive = mainMenu.IsActive,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
        }

        // PUT api/<MainMenuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MainMenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
