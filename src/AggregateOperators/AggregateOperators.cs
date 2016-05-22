using System;
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
    }
}
