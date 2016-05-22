using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace Quantifiers
{
    public class Quantifiers
    {
        public void DetermineWordsContainEI(string[] words)
        {
            var iAfterE = words.Any(w => w.Contains("ei"));

            Debug.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);
        }

        public void GroupProductsHaveAtLeastOneProduct(List<Product> products)
        {
            var productGroups = products.GroupBy(prod => prod.Category)
                .Where(prodGroup => prodGroup.Any(p => p.UnitsInStock == 0))
                .Select(prodGroup => new
                {
                    Category = prodGroup.Key,
                    Products = prodGroup
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

        public void GroupProductsAllInStock(List<Product> products)
        {
            var productGroups = products.GroupBy(prod => prod.Category)
                .Where(prodGroup => prodGroup.All(p => p.UnitsInStock > 0))
                .Select(prodGroup => new
                {
                    Category = prodGroup.Key,
                    Products = prodGroup
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