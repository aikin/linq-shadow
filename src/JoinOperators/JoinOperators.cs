using System;
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

        public void LeftOuterJoinByCountryLambda(List<Customer> customers, List<Supplier> suppliers)
        {
            var supplierCusts =
                suppliers.GroupJoin(customers, sup => sup.Country, cust => cust.Country, (sup, cs) => new {sup, cs})
                    .SelectMany(@t => @t.cs.DefaultIfEmpty(), (@t, c) => new {@t, c})
                    .OrderBy(@t => @t.@t.sup.SupplierName)
                    .Select(@t => new
                    {
                        Country = @t.@t.sup.Country,
                        CompanyName = @t.c == null ? "(No customers)" : @t.c.CompanyName,
                        SupplierName = @t.@t.sup.SupplierName
                    });

            foreach (var item in supplierCusts)
            {
                Debug.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
        }

        public void LeftOuterJoinByCountryLinq(List<Customer> customers, List<Supplier> suppliers)
        {
            var supplierCusts =
                from sup in suppliers
                join cust in customers on sup.Country equals cust.Country into cs
                from c in cs.DefaultIfEmpty()
                // DefaultIfEmpty preserves left-hand elements that have no matches on the right side 
                orderby sup.SupplierName
                select new
                {
                    Country = sup.Country,
                    CompanyName = c == null ? "(No customers)" : c.CompanyName,
                    SupplierName = sup.SupplierName
                };

            foreach (var item in supplierCusts)
            {
                Debug.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
        }

        public void LeftOuterJoinByCountryForEachCustomerLambda(List<Customer> customers, List<Supplier> suppliers)
        {
            var custSuppliers =
                customers.GroupJoin(suppliers, cust => cust.Country, sup => sup.Country, (cust, ss) => new {cust, ss})
                    .SelectMany(@t => @t.ss.DefaultIfEmpty(), (@t, s) => new {@t, s})
                    .OrderBy(@t => @t.@t.cust.CompanyName)
                    .Select(@t => new
                    {
                        Country = @t.@t.cust.Country,
                        CompanyName = @t.@t.cust.CompanyName,
                        SupplierName = @t.s == null ? "(No suppliers)" : @t.s.SupplierName
                    });

            foreach (var item in custSuppliers)
            {
                Debug.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }
        }

        public void LeftOuterJoinByCountryForEachCustomerLinq(List<Customer> customers, List<Supplier> suppliers)
        {
            var custSuppliers =
                    from cust in customers
                    join sup in suppliers on cust.Country equals sup.Country into ss
                    from s in ss.DefaultIfEmpty()
                    orderby cust.CompanyName
                    select new
                    {
                        Country = cust.Country,
                        CompanyName = cust.CompanyName,
                        SupplierName = s == null ? "(No suppliers)" : s.SupplierName
                    };

            foreach (var item in custSuppliers)
            {
                Debug.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }

        }

        public void LeftOuterJoinByCountryAndCityForEachCustomerLambda(List<Customer> customers, List<Supplier> suppliers)
        {
            var supplierCusts =
                suppliers.GroupJoin(customers, sup => new {sup.City, sup.Country}, cust => new {cust.City, cust.Country},
                    (sup, cs) => new {sup, cs})
                    .SelectMany(@t => @t.cs.DefaultIfEmpty(), (@t, c) => new {@t, c})
                    .OrderBy(@t => @t.@t.sup.SupplierName)
                    .Select(@t => new
                    {
                        Country = @t.@t.sup.Country,
                        City = @t.@t.sup.City,
                        SupplierName = @t.@t.sup.SupplierName,
                        CompanyName = @t.c == null ? "(No customers)" : @t.c.CompanyName
                    });

            foreach (var item in supplierCusts)
            {
                Debug.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
        }

        public void LeftOuterJoinByCountryAndCityForEachCustomerLinq(List<Customer> customers, List<Supplier> suppliers)
        {
            var supplierCusts =
                    from sup in suppliers
                    join cust in customers on new { sup.City, sup.Country } equals new { cust.City, cust.Country } into cs
                    from c in cs.DefaultIfEmpty() //Remove DefaultIfEmpty method call to make this an inner join
                    orderby sup.SupplierName
                    select new
                    {
                        Country = sup.Country,
                        City = sup.City,
                        SupplierName = sup.SupplierName,
                        CompanyName = c == null ? "(No customers)" : c.CompanyName
                    };

            foreach (var item in supplierCusts)
            {
                Debug.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
        }
    }
}