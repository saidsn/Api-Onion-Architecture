using Microsoft.AspNetCore.Mvc;

namespace Api_Intro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById(int id)
        {
            string name = ("Orxan" + id);
            return Ok(name);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           List<string> names = new List<string>() { "Seid","Orxan","Emil"};
            return Ok(names);
        }
    }
}
