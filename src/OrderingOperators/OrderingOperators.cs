using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace OrderingOperators
{
    public class OrderingOperators
    {
        public void SortProductsByNameLinq(List<Product> products)
        {
            var sortedProducts =
                from product in products
                orderby product.Name
                select product;

            Debug.WriteLine("Sorted Products: ");
            foreach (var product in sortedProducts)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    product.Name, product.Category, product.UnitPrice);
            }
        }

        public void SortProductsByNameLambda(List<Product> products)
        {
            var sortedProducts = products.OrderBy(product => product.Name);

            Debug.WriteLine("Sorted Products: ");
            foreach (var product in sortedProducts)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    product.Name, product.Category, product.UnitPrice);
            }
        }

        public void SortWordsByCustomComparerLambda(string[] words)
        {
            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

            Debug.WriteLine("sorted words: ");
            foreach (var word in sortedWords)
            {
                Debug.WriteLine(word);
            }
        }

        public void SortProductsByStockLinq(List<Product> products)
        {
            var sortedProducts =
                from prod in products
                orderby prod.UnitsInStock descending
                select prod;

            Debug.WriteLine("Sorted Products: ");
            foreach (var product in sortedProducts)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    product.Name, product.Category, product.UnitPrice);
            }
        }

        public void SortProductsByStockLambda(List<Product> products)
        {
            var sortedProducts =
                from prod in products
                orderby prod.UnitsInStock descending
                select prod;

            Debug.WriteLine("Sorted Products: ");
            foreach (var product in sortedProducts)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    product.Name, product.Category, product.UnitPrice);
            }
        }

        public void SortWordsDescByCustomComparerLambda(string[] words)
        {
            var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

            Debug.WriteLine("Sorted words: ");
            foreach (var word in sortedWords)
            {
                Debug.WriteLine(word);
            }
        }

        public void SortDigitsCompoundOrderByDigitLengthAndDigitLinq(string[] digits)
        {
            var sortedDigits =
                from digit in digits
                orderby digit.Length, digit
                select digit;


            Debug.WriteLine("Sorted digits:");
            foreach (var digit in sortedDigits)
            {
                Debug.WriteLine(digit);
            }
        }

        public void SortDigitsCompoundOrderByDigitLengthAndDigitLambda(string[] digits)
        {
            var sortedDigits = digits.OrderBy(digit => digit.Length).ThenBy(digit => digit);

            Debug.WriteLine("Sorted digits:");
            foreach (var digit in sortedDigits)
            {
                Debug.WriteLine(digit);
            }
        }

        public void SortWordsByCompoundCustomComparerLambda(string[] words)
        {
            var sortedWords = words.OrderBy(w => w.Length).ThenBy(w => new CaseInsensitiveComparer());

            Debug.WriteLine("Sorted words: ");
            foreach (var word in sortedWords)
            {
                Debug.WriteLine(word);
            }
        }

        public void SortProductsByCompoundCategoryAndUnitPriceDescLinq(List<Product> products)
        {
            var sortedProducts =
                from prod in products
                orderby prod.Category, prod.UnitPrice descending
                select prod;

            Debug.WriteLine("Sorted Products: ");
            foreach (var product in sortedProducts)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    product.Name, product.Category, product.UnitPrice);
            }
        }

        public void SortProductsByCompoundCategoryAndUnitPriceDescLambda(List<Product> products)
        {
            var sortedProducts = products.OrderBy(prod => prod.Category).ThenByDescending(prod => prod.UnitPrice);

            Debug.WriteLine("Sorted Products: ");
            foreach (var product in sortedProducts)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    product.Name, product.Category, product.UnitPrice);
            }
        }

        public void SortWordsByCompoundCustomComparerDescLambda(string[] words)
        {
            var sortedWords = words.OrderBy(w => w.Length).ThenByDescending(w => new CaseInsensitiveComparer());

            Debug.WriteLine("Sorted words: ");
            foreach (var word in sortedWords)
            {
                Debug.WriteLine(word);
            }
        }

        public void RevereDigitsWhoseSecondLetterIsILinq(string[] digits)
        {
            var reversedIDigits = (
                from digit in digits
                where digit[1] == 'i'
                select digit)
                .Reverse();

            Debug.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Debug.WriteLine(d);
            }
        }

        public void RevereDigitsWhoseSecondLetterIsILambda(string[] digits)
        {
            var reversedIDigits = digits.Where(digit => digit[1] == 'i').Reverse();

            Debug.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Debug.WriteLine(d);
            }
        }
    }

    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}