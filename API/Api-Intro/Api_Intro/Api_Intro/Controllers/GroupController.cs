using Api_Intro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
     
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Group> groups = new List<Group>();

            Group group1 = new()
            { 
                id = 1,
                Name= "P130",
                Capacity= 10,
            };

            Group group2 = new()
            {
                id = 2,
                Name = "P126",
                Capacity = 15,
            };

            Group group3 = new()
            {
                id = 3,
                Name = "P135",
                Capacity = 30,
            };

            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);
            
            return Ok(groups);

        }
    }
}
