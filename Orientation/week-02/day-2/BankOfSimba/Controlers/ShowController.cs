using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;


namespace BankOfSimba.Controlers
{

    public class HomeController : Controller
    {
        public static List<BankAccount> bankAccount = new List<BankAccount>() 
        { 
            new BankAccount("Simba", 4000, "lion"),
            new BankAccount("Mufasa", 8000, "lion"),
            new BankAccount("Scar", 800, "lion", false, false),
            new BankAccount("Pumba", 1200, "boar", false),
            new BankAccount("Timon", 1700, "suricata", false)
        };

        [Route("")]
        public IActionResult Account()
        {
            List<BankAccount> bankAccount = new List<BankAccount>();
            bankAccount.Add(new BankAccount("Simba", 2000, "lion"));
            return View(bankAccount);
        }

        [Route("view1")]
        public IActionResult View1()
        {   
            return View(bankAccount);
        }

        [HttpPost("bankaccount/create")]
        public IActionResult Create(BankAccount account)
        {
            bankAccount.Add(account);
            return RedirectToAction("view1");
        }
    }
}