﻿using Microsoft.EntityFrameworkCore;
using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Phone",Url="phone"},
            new Category(){Name="Laptop",Url="laptop"},
            new Category(){Name="Electronic",Url="elektronic"}
           
        };

        private static Product[] Products = {
            new Product(){Name="Samsung S5",Url="samsung-s5",Price=2000,ImageUrl="1.jpg",Description="Good phone", IsApproved=true},
            new Product(){Name="Samsung S6",Url="samsung-s6",Price=3000,ImageUrl="2.jpg",Description="Good phone", IsApproved=false},
            new Product(){Name="Samsung S7",Url="samsung-s7",Price=4000,ImageUrl="3.jpg",Description="Good phone", IsApproved=true},
            new Product(){Name="Samsung S8",Url="samsung-s8",Price=5000,ImageUrl="4.jpg",Description="Good phone", IsApproved=false},
            new Product(){Name="Samsung S9",Url="samsung-s9",Price=6000,ImageUrl="5.jpg",Description="Good phone", IsApproved=true},
        };

        private static ProductCategory[] ProductCategories ={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
        };
    }
}
