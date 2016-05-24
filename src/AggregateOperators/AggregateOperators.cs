using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace AggregateOperators
{
    public class AggregateOperators
    {
        public void CountOddNumbers(int[] numbers)
        {
            var oddNumbers = numbers.Count(n => n % 2 == 1);

            Debug.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }

        public void CountCustomerOrders(List<Customer> customers, List<Order> orders)
        {
            var orderCounts = customers.Select(cust => new {
                CustomerId = cust.Id,
                OrderCount = orders.Count(order => cust.Id == order.CustomerId)
            });


            Debug.WriteLine("Customer Orders Count: ");
            foreach (var orderCount in orderCounts)
            {
                Debug.WriteLine($"CustomerId: {orderCount.CustomerId}    OrderCount: {orderCount.OrderCount}");
            }
        }

        public void CountProductsInEachCategory(List<Product> products)
        {

            var categoryCounts = products
                .GroupBy(prod => prod.Category)
                .Select(prodGroup => new
                {
                    Category = prodGroup.Key,
                    ProductCount = prodGroup.Count()
                });

            Debug.WriteLine("Category Products Count: ");
            foreach (var categoryCount in categoryCounts)
            {
                Debug.WriteLine($"Category: {categoryCount.Category}    ProductCount: {categoryCount.ProductCount}");
            }
        }

        public void SumTotalCharsOfAllWords(string[] words)
        {
            double totalChars = words.Sum(w => w.Length);

            Debug.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

        public void SumTotalUnitsInStockForEachProductCategory(List<Product> products)
        {
            var categories = products
                .GroupBy(prod => prod.Category)
                .Select(prodGroup => new
                {
                    Category = prodGroup.Key,
                    TotalUnitsInStock = prodGroup.Sum(p => p.UnitsInStock)
                });


            Debug.WriteLine("Category Products Count: ");
            foreach (var categoryCount in categories)
            {
                Debug.WriteLine($"Category: {categoryCount.Category}    TotalUnitsInStock: {categoryCount.TotalUnitsInStock}");
            }
        }

        public void MinCheapestCategoryProducts(List<Product> products)
        {
            var cheapestCategories = products
                .GroupBy(p => p.Category)
                .Select(productGroup => new
                {
                    Category = productGroup.Key,
                    CheapestPrice = productGroup.Min(p => p.UnitPrice)
                });

            Debug.WriteLine("Category Products Count: ");
            foreach (var categories in cheapestCategories)
            {
                Debug.WriteLine($"Category: {categories.Category}    CheapestPrice: {categories.CheapestPrice}");
            }
        }

        public void MinPriceInEachCategory(List<Product> products)
        {
            var cheapestCategories = products
                .GroupBy(prod => prod.Category)
                .Select(productGroup => new { productGroup, minPrice = productGroup.Min(p => p.UnitPrice) })
                .Select(productGroupWithMinPrice => new
                {
                    Category = productGroupWithMinPrice.productGroup.Key,
                    CheapestProducts = productGroupWithMinPrice.productGroup.Where(p => p.UnitPrice == productGroupWithMinPrice.minPrice)
                });

            Debug.WriteLine("Category Products Count: ");
            foreach (var categorie in cheapestCategories)
            {
                Debug.WriteLine($"Category: {categorie.Category}");
                foreach (var cheapestProduct in categorie.CheapestProducts)
                {
                    Debug.WriteLine($"Category Products:   ProductId={cheapestProduct.Id}   ProductName={cheapestProduct.Name}   ProductPrice={cheapestProduct.UnitPrice}");
                }
            }
        }

        public void MaxWordHasLongLength(string[] words)
        {
            var longest = words.Max(w => w.Length);

            Debug.WriteLine($"The longest word is {longest} characters long.");
        }

        public void AverageAllNumbers(int[] numbers)
        {
            var average = numbers.Average();
            Debug.WriteLine($"The average number is {average}");
        }

        public void AggregateCalculateTotal(double[] doubles)
        {
            var product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
            Debug.WriteLine("Total product of all numbers: {0}", product);
        }

        public void AggregateSubWithdrawalsInitWith100(int[] withdrawals, double startBalance)
        {
            var endBalance = withdrawals.Aggregate(startBalance, (balance, nextWithdrawal) => ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Debug.WriteLine("Ending balance: {0}", endBalance);
        }
    }
}
