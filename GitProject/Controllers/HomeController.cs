using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Home Ok!");
        }

        [HttpGet]
        public IActionResult GetALl()
        {
            return Ok("Home Get all Ok!");
        }
    }
}
