using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greetings")]
        public IActionResult Greetings(string name)
        {
            var greetings = new Greetings(WebApplication1.Models.Greetings.counter++, name);
            

            return View(greetings);
        }
    }
}