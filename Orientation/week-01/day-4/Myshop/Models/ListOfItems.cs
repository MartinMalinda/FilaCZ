﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myshop.Models
{
    public class ListOfItems
    {

        public static List<ShopItem> GetItems()
        {
            var listOfItems = new List<ShopItem>();
            listOfItems.Add(new ShopItem("Running shoes", "Nike running shoes for every day sport", 1000, 5));
            listOfItems.Add(new ShopItem("Printer", "Some HP printer", 3000, 2));
            listOfItems.Add(new ShopItem("Coca-Cola", "0.5l standard coke", 25, 0));
            listOfItems.Add(new ShopItem("Wokin", "Chicken with fried rice and WOKIN sauce", 119, 100));
            listOfItems.Add(new ShopItem("T-shirt", "Blue with corgi on bike", 300, 1));
            return listOfItems;
        }
        

    }
}
