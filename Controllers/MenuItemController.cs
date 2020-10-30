using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDockerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return new List<MenuItem> {new MenuItem()
                {
                    Id = 1,
                    Name = "Chicken",
                    Price = 150,
                    Active = true,
                    DateOfLaunch = Convert.ToDateTime("2002-12-12 12:12:00.0000000"),
                    FreeDelivery = true
                },
            new MenuItem()
                {
                    Id = 2,
                    Name = "Tomato Soup",
                    Price = 50,
                    Active = true,
                    DateOfLaunch = Convert.ToDateTime("2002-12-12 12:12:00.0000000"),
                    FreeDelivery = true
                }};
        }
    }
}
