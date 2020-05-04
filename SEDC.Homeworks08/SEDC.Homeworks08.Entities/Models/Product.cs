using SEDC.Homeworks08.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homeworks08.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            Id = IdGenerator.GenerateId();
        }

        public Product(string name, int price, Category category)
        {
            Id = IdGenerator.GenerateId();
            Name = name;
            Price = price;
            Category = category;
        }

        public string Info()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price} MKD";
        }
    }
}
