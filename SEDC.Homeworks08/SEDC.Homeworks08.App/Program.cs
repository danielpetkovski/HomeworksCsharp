using SEDC.Homework08.Data;
using SEDC.Homeworks08.Entities;
using System;

namespace SEDC.Homeworks08.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();

            //Console.WriteLine(productRepository.GetProductById(2).Info());   Get products by ID

            //productRepository.ShowSearchedProducts(productRepository.GetProductsByCategory(Entities.Enums.Category.LapTop));   -- Get products by category

            //productRepository.ShowSearchedProducts(productRepository.GetProductsByPartOfName("H")); --- Get products by part of name

            //productRepository.ShowProductIds(productRepository.GetProductIds(productRepository.Products)); -- show every product ids

            //productRepository.ShowSearchedProducts(productRepository.FilteredByPriceRange(100, 99999)); --- filter products by price range

            //Console.WriteLine(productRepository.GetCheapestProduct().Info());   --- show cheapest product

            //Console.WriteLine(productRepository.GetMostExpensiveProduct().Info());  --- show most expensive product

            //productRepository.AddProduct("Acer", 4500, Entities.Enums.Category.LapTop); ++++ adding product

            //productRepository.ShowSearchedProducts(productRepository.GetProductsByPartOfName("Acer")); ++++ showing added product

            //Console.WriteLine(productRepository.RemoveProduct(18)); ---- removing product


            




            Console.ReadLine();
        }
    }
}
