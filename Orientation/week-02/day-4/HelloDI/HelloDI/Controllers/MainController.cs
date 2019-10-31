using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloDI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloDI.Controllers
{
    
    public class MainController : Controller
    {
        private UtilityService UtilityService { get; set; } //dependency
        private EmailValidation EmailValidation { get; set; }

        public MainController(UtilityService utilityService, EmailValidation emailValidation)
        {
            this.UtilityService = utilityService;
            this.EmailValidation = emailValidation;
        }


        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("colored")]
        public IActionResult ColoredBackground()
        {
            return View("coloredbackground", UtilityService.RandomColor()); //returning string (ColoredBackground is expecting @model string)
        }

        [Route("validation")]
        public IActionResult Validation()
        {
            return View();
        }

        [HttpPost("email/validate")]
        public IActionResult Validated(string email)
        {
            EmailValidation emailObject = new EmailValidation();
            emailObject.Email = email;
            emailObject.ValidateEmail(email);
            return View(emailObject);
        }
    }
}