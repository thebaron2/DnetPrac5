﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShopServerLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public List<Product> BoughtProducts { get; set; }


        public List<Product> FillBoughtProducts()
        {
            BoughtProducts = new List<Product>();
            this.BoughtProducts.Add(
                new Product
                {
                    Name = "Carrot",
                    Amount = 1,
                    Price = 2.50,
                    Id = 1
                });

            return BoughtProducts;
        }

        public List<User> GenerateUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User
            {
                Id = 1,
                Username = "owen",
                Password = "newo",
                Balance = 50,
                BoughtProducts = new List<Product>()
            });

            return users;
        }
    }
}
