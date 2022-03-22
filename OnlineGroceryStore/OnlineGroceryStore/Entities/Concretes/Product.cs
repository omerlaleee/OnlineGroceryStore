using OnlineGroceryStore.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Entities.Concretes
{
    public class Product : IEntity
    {
        private int Id;
        private string Name;
        private float Price;
        private string Description;
        private string Image;

        public Product(string name, float price, string description, string imagePath)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Image = imagePath;
        }

        public Product(int id, string name, float price, string description, string imagePath)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Image = imagePath;
        }

        public int id { get => Id; set => Id = value; }
        public string name { get => Name; set => Name = value; }
        public float price { get => Price; set => Price = value; }
        public string description { get => Description; set => Description = value; }
        public string imagePath { get => Image; set => Image = value; }
    }
}
