using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("greetings")]
        public Greetings Greet(string name)
        {     
            return new Greetings(Greetings.counter++, $"Hello, {name}!");
        }
    }
}