using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq.Shadow.Common
{
    public class DataProvider
    {
        public static int[] GivenNumbers()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers;
        }

        public static string[] GivenStrings()
        {
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return strings;
        }

        public static List<Product> GivenProducts()
        {
            var products = new List<Product>
            {
                new Product(1, "Chai", "Beverages", 18.0000M, 39),
                new Product(2, "Chang", "Beverages", 19.0000M, 17),
                new Product(3, "Aniseed Syrup", "Condiments", 10.0000M, 13),
                new Product(4, "Chef Anton's Cajun Seasoning", "Condiments", 22.0000M, 53),
                new Product(5, "Chef Anton's Gumbo Mix", "Condiments", 21.3500M, 0),
                new Product(6, "Grandma's Boysenberry Spread", "Condiments", 25.0000M, 120),
                new Product(7, "Uncle Bob's Organic Dried Pears", "Produce", 30.0000M, 15),
                new Product(8, "Northwoods Cranberry Sauce", "Condiments", 40.0000M, 6),
                new Product(9, "Mishi Kobe Niku", "Meat/Poultry", 97.0000M, 29),
                new Product(10, "Ikura", "Seafood", 31.0000M, 31),
                new Product(11, "Queso Cabrales", "Dairy Products", 21.0000M, 22),
                new Product(12, "Queso Manchego La Pastora", "Dairy Products", 38.0000M, 86),
                new Product(13, "Konbu", "Seafood", 6.0000M, 24),
                new Product(14, "Tofu", "Produce", 23.2500M, 35),
                new Product(15, "Genen Shouyu", "Condiments", 15.5000M, 39),
                new Product(16, "Pavlova", "Confections", 17.4500M, 29),
                new Product(17, "Alice Mutton", "Meat/Poultry", 39.0000M, 0),
                new Product(18, "Carnarvon Tigers", "Seafood", 62.5000M, 42),
                new Product(19, "Teatime Chocolate Biscuits", "Confections", 9.2000M, 25),
                new Product(20, "Sir Rodney's Marmalade", "Confections", 81.0000M, 40),
                new Product(21, "Sir Rodney's Scones", "Confections", 10.0000M, 3),
                new Product(22, "Gustaf's Knäckebröd", "Grains/Cereals", 21.0000M, 104),
                new Product(23, "Tunnbröd", "Grains/Cereals", 9.0000M, 61),
                new Product(24, "Guaraná Fantástica", "Beverages", 4.5000M, 20),
                new Product(25, "NuNuCa Nuß-Nougat-Creme", "Confections", 14.0000M, 76),
                new Product(26, "Gumbär Gummibärchen", "Confections", 31.2300M, 15),
                new Product(27, "Schoggi Schokolade", "Confections", 43.9000M, 49),
                new Product(28, "Rössle Sauerkraut", "Produce", 45.6000M, 26),
                new Product(29, "Thüringer Rostbratwurst", "Meat/Poultry", 123.7900M, 0),
                new Product(30, "Nord-Ost Matjeshering", "Seafood", 25.8900M, 10),
                new Product(31, "Gorgonzola Telino", "Dairy Products", 12.5000M, 0),
                new Product(32, "Mascarpone Fabioli", "Dairy Products", 32.0000M, 9),
                new Product(33, "Geitost", "Dairy Products", 2.5000M, 112),
                new Product(34, "Sasquatch Ale", "Beverages", 14.0000M, 111),
                new Product(35, "Steeleye Stout", "Beverages", 18.0000M, 20),
                new Product(36, "Inlagd Sill", "Seafood", 19.0000M, 112),
                new Product(37, "Gravad lax", "Seafood", 26.0000M, 11),
                new Product(38, "Côte de Blaye", "Beverages", 263.5000M, 17),
                new Product(39, "Chartreuse verte", "Beverages", 18.0000M, 69),
                new Product(40, "Boston Crab Meat", "Seafood", 18.4000M, 123),
                new Product(41, "Jack's New England Clam Chowder", "Seafood", 9.6500M, 85),
                new Product(42, "Singaporean Hokkien Fried Mee", "Grains/Cereals", 14.0000M, 26),
                new Product(43, "Ipoh Coffee", "Beverages", 46.0000M, 17),
                new Product(44, "Gula Malacca", "Condiments", 19.4500M, 27),
                new Product(45, "Rogede sild", "Seafood", 9.5000M, 5),
                new Product(46, "Spegesild", "Seafood", 12.0000M, 95),
                new Product(47, "Zaanse koeken", "Confections", 9.5000M, 36),
                new Product(48, "Chocolade", "Confections", 12.7500M, 15),
                new Product(49, "Maxilaku", "Confections", 20.0000M, 10),
                new Product(50, "Valkoinen suklaa", "Confections", 16.2500M, 65),
                new Product(51, "Manjimup Dried Apples", "Produce", 53.0000M, 20),
                new Product(52, "Filo Mix", "Grains/Cereals", 7.0000M, 38),
                new Product(53, "Perth Pasties", "Meat/Poultry", 32.8000M, 0),
                new Product(54, "Tourtière", "Meat/Poultry", 7.4500M, 21),
                new Product(55, "Pâté chinois", "Meat/Poultry", 24.0000M, 115),
                new Product(56, "Gnocchi di nonna Alice", "Grains/Cereals", 38.0000M, 21),
                new Product(57, "Ravioli Angelo", "Grains/Cereals", 19.5000M, 36),
                new Product(58, "Escargots de Bourgogne", "Seafood", 13.2500M, 62),
                new Product(59, "Raclette Courdavault", "Dairy Products", 55.0000M, 79),
                new Product(60, "Camembert Pierrot", "Dairy Products", 34.0000M, 19),
                new Product(61, "Sirop d'érable", "Condiments", 28.5000M, 113),
                new Product(62, "Tarte au sucre", "Confections", 49.3000M, 17),
                new Product(63, "Vegie-spread", "Condiments", 43.9000M, 24),
                new Product(64, "Wimmers gute Semmelknödel", "Grains/Cereals", 33.2500M, 22),
                new Product(65, "Louisiana Fiery Hot Pepper Sauce", "Condiments", 21.0500M, 76),
                new Product(66, "Louisiana Hot Spiced Okra", "Condiments", 17.0000M, 4),
                new Product(67, "Laughing Lumberjack Lager", "Beverages", 14.0000M, 52),
                new Product(68, "Scottish Longbreads", "Confections", 12.5000M, 6),
                new Product(69, "Gudbrandsdalsost", "Dairy Products", 36.0000M, 26),
                new Product(70, "Outback Lager", "Beverages", 15.0000M, 15),
                new Product(71, "Flotemysost", "Dairy Products", 21.5000M, 26),
                new Product(72, "Mozzarella di Giovanni", "Dairy Products", 34.8000M, 14),
                new Product(73, "Röd Kaviar", "Seafood", 15.0000M, 101),
                new Product(74, "Longlife Tofu", "Produce", 10.0000M, 4),
                new Product(75, "Rhönbräu Klosterbier", "Beverages", 7.7500M, 125),
                new Product(76, "Lakkalikööri", "Beverages", 18.0000M, 57),
                new Product(77, "Original Frankfurter grüne Soße", "Condiments", 13.0000M, 32)
            };

            return products;
        }

        public static string[] GivenWords()
        {
            string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};
            return words;
        }

        public static int[] GivenNumbersA()
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            return numbersA;
        }

        public static int[] GivenNumbersB()
        {
            int[] numbersB = {1, 3, 5, 7, 8};
            return numbersB;
        }

        public static List<Customer> GivenCustomers()
        {
            var xElement = XDocument.Load("Customers.xml").Root;
            if (xElement == null) return new List<Customer>();
                
            return xElement
                .Elements("customer")
                .Select(e => new Customer
                {
                    Id = (string) e.Element("id"),
                    CompanyName = (string) e.Element("name"),
                    Address = (string) e.Element("address"),
                    City = (string) e.Element("city"),
                    Region = (string) e.Element("region"),
                    PostalCode = (string) e.Element("postalcode"),
                    Country = (string) e.Element("country"),
                    Phone = (string) e.Element("phone"),
                    Fax = (string) e.Element("fax")
                })
                .ToList();
        }

        public static List<Order> GivenOrders()
        {
            var xElement = XDocument.Load("customers.xml").Root;
            if (xElement == null) return new List<Order>();

            return xElement.Elements("customer")
                .SelectMany(e => e.Elements("orders").Elements("order"), (e, o) => new Order
                {
                    Id = (string) o.Element("id"),
                    CustomerId = (string) e.Element("id"),
                    OrderDate = (DateTime) o.Element("orderdate"),
                    Total = (decimal) o.Element("total")
                })
                .ToList();
        }
    }

    public class Customer
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }

    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string CustomerId { get; set; }
    }

    public class Product
    {
        public Product(int id, string name, string category, decimal unitPrice, int unitsInStock)
        {
            Id = id;
            Name = name;
            Category = category;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}