using OnlineGroceryStore.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Entities.Concretes
{
    public class ShoppingCart : IEntity
    {
        private User User;
        private Product Product;
        private int Amount;

        public ShoppingCart(User user, Product product, int amount)
        {
            this.User = user;
            this.Product = product;
            this.Amount = amount;
        }

        public User user { get => User; set => User = value; }
        public Product product { get => Product; set => Product = value; }
        public int amount { get => Amount; set => Amount = value; }
    }
}
