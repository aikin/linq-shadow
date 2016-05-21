using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
    }
}