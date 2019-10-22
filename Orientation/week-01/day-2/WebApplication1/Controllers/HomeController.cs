using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public string Index()
        {
            string greet = "Hello from the Controller!";
            return greet;
        }
    }
}