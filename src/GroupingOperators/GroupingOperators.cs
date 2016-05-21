using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using Linq.Shadow.Common;

namespace GroupingOperators
{
    public class GroupingOperators
    {
        public void GroupProductsByCategoryLinq(List<Product> products)
        {
            var productGroups =
                from product in products
                group product by product.Category
                into g
                select new
                {
                    Category = g.Key,
                    Products = g
                };

            Debug.WriteLine("Grouped Products: ");
            foreach (var g in productGroups)
            {
                Debug.WriteLine("Category: {0}", g.Category);
                foreach (var w in g.Products)
                {
                    Debug.WriteLine("\t" + w.Name);
                }
            }
        }

        public void GroupProductsByCategoryLambda(List<Product> products)
        {
            var productGroups = products
                .GroupBy(product => product.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Products = g
                });

            Debug.WriteLine("Grouped Products: ");
            foreach (var g in productGroups)
            {
                Debug.WriteLine("Category: {0}", g.Category);
                foreach (var w in g.Products)
                {
                    Debug.WriteLine("\t" + w.Name);
                }
            }
        }

        public void GroupOrdersByNestedConditionsLinq(List<Customer> customers, List<Order> orders)
        {
            var customerOrderGroups =
                from customer in customers
                select new
                {
                    CompanyName = customer.CompanyName,
                    YearGroups =
                        from order in orders
                        where customer.Id == order.CustomerId
                        group order by order.OrderDate.Year
                        into yg
                        select new
                        {
                            Year = yg.Key,
                            MonthGroups =
                                from order in yg
                                group order by order.OrderDate.Month
                                into mg
                                select new
                                {
                                    Month = mg.Key,
                                    Orders = mg
                                }
                        }
                };

            foreach (var cog in customerOrderGroups)
            {
                Debug.WriteLine($"CompanyName= {cog.CompanyName}");
                foreach (var yg in cog.YearGroups)
                {
                    Debug.WriteLine($"\t Year= {yg.Year}");
                    foreach (var mg in yg.MonthGroups)
                    {
                        Debug.WriteLine($"\t\t Month= {mg.Month}");
                        foreach (var order in mg.Orders)
                        {
                            Debug.WriteLine($"\t\t\t OrderID= {order.Id}");
                            Debug.WriteLine($"\t\t\t OrderDate= { order.OrderDate }");
                        }
                    }
                }
            }

        }
    }
}