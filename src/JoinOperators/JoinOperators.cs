using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace JoinOperators
{
    public class JoinOperators
    {
        public void InnerJoinTwoSequencesLambda(List<Customer> customers, List<Supplier> suppliers)
        {
            var customerSupplierJoin = suppliers
                .Join(customers, sup => sup.Country, cust => cust.Country, (sup, cust) => new
                {
                    Country = sup.Country,
                    SupplierName = sup.SupplierName,
                    CustomerName = cust.CompanyName
                });

            Debug.WriteLine("Suppliers Join Cumtomers");
            foreach (var item in customerSupplierJoin)
            {
                Debug.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", item.Country, item.SupplierName,
                    item.CustomerName);
            }
        }

        public void InnerJoinTwoSequencesLinq(List<Customer> customers, List<Supplier> suppliers)
        {
            var customerSupplierJoin =
                from sup in suppliers
                join cust in customers on sup.Country equals cust.Country
                select new
                {
                    Country = sup.Country,
                    SupplierName = sup.SupplierName,
                    CustomerName = cust.CompanyName
                };

            Debug.WriteLine("Suppliers Join Cumtomers");
            foreach (var item in customerSupplierJoin)
            {
                Debug.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", item.Country, item.SupplierName,
                    item.CustomerName);
            }
        }

        public void GroupJoinTwoSequencesLambda(List<Customer> customers, List<Supplier> suppliers)
        {
            var customerSupplierJoin = suppliers
                .GroupJoin(customers, sup => sup.Country, cust => cust.Country, (sup, cust) => new
                {
                    Key = sup.Country,
                    Customers = cust
                });

            Debug.WriteLine("Suppliers Group Join Cumtomers");
            foreach (var item in customerSupplierJoin)
            {
                Debug.WriteLine(item.Key + ":");
                foreach (var customer in item.Customers)
                {
                    Debug.WriteLine("   " + customer.CompanyName);
                }
            }
        }

        public void GroupJoinTwoSequencesLinq(List<Customer> customers, List<Supplier> suppliers)
        {
            var customerSupplierJoin =
                from sup in suppliers
                join cust in customers on sup.Country equals cust.Country into cs
                select new
                {
                    Key = sup.Country,
                    Customers = cs
                };


            Debug.WriteLine("Suppliers Group Join Cumtomers");
            foreach (var item in customerSupplierJoin)
            {
                Debug.WriteLine(item.Key + ":");
                foreach (var customer in item.Customers)
                {
                    Debug.WriteLine("   " + customer.CompanyName);
                }
            }
        }

        public void CrossJoinByCategoriesLambda(List<Product> products)
        {
            var categories = new[]
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            var productsByCategory = categories
                .GroupJoin(products, category => category, product => product.Category,
                    (category, prods) => new {category, prods})
                .SelectMany(productsWithCategory => productsWithCategory.prods, (productsWithCategory, product) => new
                {
                    Category = productsWithCategory.category,
                    ProductName = product.Name
                });


            Debug.WriteLine("Products By Category: ");
            foreach (var product in productsByCategory)
            {
                Debug.WriteLine(product.ProductName + ": " + product.Category);
            }
        }

        public void CrossJoinByCategoriesLinq(List<Product> products)
        {
            var categories = new[]
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            var productsByCategory =
                from cat in categories
                join prod in products on cat equals prod.Category into ps
                from p in ps
                select new
                {
                    Category = p.Category,
                    ProductName = p.Name
                };


            Debug.WriteLine("Products By Category: ");
            foreach (var product in productsByCategory)
            {
                Debug.WriteLine(product.ProductName + ": " + product.Category);
            }
        }
    }
}