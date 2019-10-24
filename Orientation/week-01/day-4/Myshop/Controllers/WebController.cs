using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Myshop.Models;

namespace Myshop.Controllers
{
    [Route("")]
    public class WebController : Controller
    {
        [HttpGet("")]
        public IActionResult MyShop()
        {

            //ViewBag.items = ListOfItems.GetItems(); working same as line under (better solution)
            List<ShopItem> itemsList = ListOfItems.GetItems();
            return View(itemsList);
        }

        /*[HttpGet("myshop")]
        public IActionResult NavBarItems()
        {

            ViewData["header"] = "My Shop";
            return View("MyShop.cshtml");
        }*/
    }
}