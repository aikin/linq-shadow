using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    public class DataProvider
    {
        public static int[] GivenNumbers()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            return numbers;
        }

        public static List<Product> GivenProducts()
        {
            var products = new List<Product>();

            return products;
        } 
 
        
    }

    public class Product
    {
        private int id;
        private string name;
        private string category;
        private decimal unitPrice;
        private int unitsInStock;

        public Product(int id, string name, string category, decimal unitPrice, int unitsInStock)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.unitPrice = unitPrice;
            this.unitsInStock = unitsInStock;
        }
    }
}
