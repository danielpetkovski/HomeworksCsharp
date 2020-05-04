using SEDC.Homework.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Collections.Methods
{
    public class Methods : Product
    {
        public Methods()
            : base ()
        {
        }
        public List<Product> SearchByCategory(string category)
        {
            List<Product> categorizedProducts = new List<Product> { };
            foreach (var product in Products)
            {
                if (product.Category.ToString() == category)
                {
                    categorizedProducts.Add(product);
                }
            }
            return categorizedProducts;

        }
    }
}
