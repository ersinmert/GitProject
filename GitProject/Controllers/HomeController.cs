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
            var degisken = 1;
            return Ok("Home Ok!");
        }

        [HttpGet]
        public IActionResult GetALl()
        {
            var degisken = 1;
            return Ok("Home Get all Ok!");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Home Put all Ok!");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Home Get all Ok!");
        }

    }
}
