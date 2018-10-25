using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace assignment4Server.Models
{
    public class ShoppingListContext : DbContext
    {

        public ShoppingListContext(DbContextOptions<ShoppingListContext> options)
            : base(options)
        {
            if (ShoppingList.Count() == 0)
            {
                ShoppingList.Add(new ShoppingItem { Title = "Google Pixel 3", Description = "A Google Product", Url = "https://images.idgesg.net/images/article/2018/10/pixel_3_xl_bigger_notch_long-100776124-large.jpg", Price = 800 });
                ShoppingList.Add(new ShoppingItem { Title = "iPhone X", Description = "An Apple Product", Url = "https://cnet4.cbsistatic.com/img/KnuL1WDed3sanatLbE4YDddJGVg=/2017/10/31/312b3b6e-59b7-499a-aea4-9bc5f9721a21/iphone-x-54.jpg", Price = 1000});
                SaveChanges();
            }
        }

        public DbSet<ShoppingItem> ShoppingList { get; set; }
    }

}
