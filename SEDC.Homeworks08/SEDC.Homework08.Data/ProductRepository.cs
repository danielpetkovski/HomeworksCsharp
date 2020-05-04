using SEDC.Homeworks08.Entities;
using SEDC.Homeworks08.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework08.Data
{
    public class ProductRepository : Database
    {
        public ProductRepository()
            : base()
        {
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product GetProductById(int productId)
        {
            
            foreach (Product product in Products)
            {
                if (product.Id == productId)
                {
                    return product;
                }
            }
            return null;   
        }

        public void ShowSearchedProducts(List<Product> list)
        {   
            if(list.Count < 1 || list == null)
            {
                Console.WriteLine("No items");
            }
            else
            {
                foreach (Product product in list)
                {
                    Console.WriteLine(product.Info());
                }
            }
            
        }
        public void ShowProductIds(List<int> list)
        {
            if (list.Count < 1 || list == null)
            {
                Console.WriteLine("No items");
            }
            else
            {
                foreach (int id in list)
                {
                    Console.WriteLine(id);
                }
            }

        }


        public List<Product> GetProductsByCategory(Category category)
        {
            List<Product> searchedCategoryList = new List<Product>();
            foreach (Product product in Products)
            {
                if(product.Category == category)
                {
                    searchedCategoryList.Add(product);
                }
            }
          
            return searchedCategoryList;
        }

        public List<Product> GetProductsByPartOfName(string name)
        {
            List<Product> searchedPartOfName = new List<Product>();

            foreach (Product product in Products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    searchedPartOfName.Add(product);
                }
            }
            //if (searchedPartOfName.Count < 1)
            //{
            //    return null;
            //}
            return searchedPartOfName;
        }

        public List<int> GetProductIds(List<Product> products)
        {
            List<int> productsIds = new List<int>();
            foreach (Product product in Products)
            {
                productsIds.Add(product.Id);
            }
            return productsIds;
        }

        public List<Product> FilteredByPriceRange(int min, int max)
        {
            List<Product> filteredByPriceRange = new List<Product>();
            foreach (var product in Products)
            {
                if (product.Price >= min && product.Price <= max)
                {
                    filteredByPriceRange.Add(product);
                }
            }
            return filteredByPriceRange;
        }

        public Product GetCheapestProduct()
        {
            int cheapestProduct = Products[0].Price;
            Product cheapestProduct1 = new Product();
            foreach (var product in Products)
            {
                if(product.Price < cheapestProduct)
                {
                    cheapestProduct = product.Price;
                    cheapestProduct1 = product;
                }
            }
            return cheapestProduct1;
            
        }

        public Product GetMostExpensiveProduct()
        {
            int mostExpensiveProduct = Products[0].Price;
            Product mostExpensiveProduct1 = new Product();
            foreach (var product in Products)
            {
                if (product.Price > mostExpensiveProduct)
                {
                    mostExpensiveProduct = product.Price;
                    mostExpensiveProduct1 = product;
                }
            }
            return mostExpensiveProduct1;

        }

        public void AddProduct(string name, int price, Category category)
        {
            Products.Add(new Product(name,price,category));
        }

        public string RemoveProduct(int id)
        {
            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    Products.Remove(product);
                    return $"Your product {product.Name} has been removed";
                }
                
            }
            return "There is no such product";
        }

    }
}
