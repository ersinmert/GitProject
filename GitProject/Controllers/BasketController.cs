using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("basket Ok!");
        }
    }
}
