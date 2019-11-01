using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        //List<Models.Fox> foxes = new List<Models.Fox>();

        private FoxService FoxService { get; set; }

        public HomeController(FoxService foxService)
        {
            this.FoxService = foxService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            FoxService.AddFoxToList(name);
            return RedirectToAction("information", "home", new { Name = name }); //cant redirect to HttpPost!!!! Use Route
        }

        [Route("information")] //Route because of redirect
        public IActionResult Information(string name)
        {
            var fox = FoxService.GetFox(name);
            return View("information", fox);
        }
    }
}