using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace RestrictionOperators
{
    public class RestrictionOperators
    {
        public void FindNumbersLessThanFiveLinq(int[] numbers)
        {
            var lowNums =
                from num in numbers
                where num < 5
                select num;

            Debug.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Debug.WriteLine(num);
            }
        }

        public void FindNumbersLessThanFiveLambda(int[] numbers)
        {
            var lowNums = numbers.Where(num => num < 5);

            Debug.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Debug.WriteLine(num);
            }
        }

        public void FindOutOfStockProductsLinq(List<Product> products)
        {
            var soldOutProducts =
                from prod in products
                where prod.UnitsInStock == 0
                select prod;

            Debug.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Debug.WriteLine("{0} is sold out!", product.Name);
            }
        }

        public void FindOutOfStockProductsLambda(List<Product> products)
        {
            var soldOutProducts = products.Where(prod => prod.UnitsInStock == 0);

            Debug.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Debug.WriteLine("{0} is sold out!", product.Name);
            }
        }

        public void FindCostMoreThanThreePerUnitProductsLinq(List<Product> products)
        {
            var expensiveInStockProducts =
                from prod in products
                where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                select prod;

            Debug.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Debug.WriteLine("{0} is in stock and costs more than 3.00.", product.Name);
            }
        }

        public void FindCostMoreThanThreePerUnitProductsLambda(List<Product> products)
        {
            var expensiveInStockProducts = products.Where(prod => prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M);

            Debug.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Debug.WriteLine("{0} is in stock and costs more than 3.00.", product.Name);
            }
        }

        public void FindCustombersInWashingtonLinq(List<Customer> customers)
        {
            var waCustomers =
                from cust in customers
                where cust.Region == "WA"
                select cust;

            Debug.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                Debug.WriteLine("Customer {0}: {1}", customer.Id, customer.CompanyName);
            }
        }

        public void FindCustombersInWashingtonLambda(List<Customer> customers)
        {
            var waCustomers = customers.Where(cust => cust.Region == "WA");

            Debug.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                Debug.WriteLine("Customer {0}: {1}", customer.Id, customer.CompanyName);
            }
        }

        public void FindDigitsWhoseNameIsShorterThanTheirValueLambda(string[] digits)
        {
            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Debug.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Debug.WriteLine("The word {0} is shorter than its value.", d);
            }
        }
    }
}