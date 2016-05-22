using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace SetOperators
{
    public class SetOperators
    {
        public void UniqueDuplicateFactorsOf300(int[] factorsOf300)
        {
            var uniqueFactors = factorsOf300.Distinct();

            Debug.WriteLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                Debug.WriteLine(f);
            }
        }

        public void UniqueCategoryNames(List<Product> products)
        {
            var uniqueCategoryNames = products.Select(p => p.Category).Distinct();

            Debug.WriteLine("Category names:");
            foreach (var n in uniqueCategoryNames)
            {
                Debug.WriteLine(n);
            }
        }

        public void UnionFistLetterFromCustomerNamesAndProductNames(List<Product> products, List<Customer> customers)
        {
            var productFirstLetters = products.Select(prod => prod.Name.First());
            var customerFirstLetters = customers.Select(cust => cust.CompanyName.First());

            var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters);


            Debug.WriteLine("Unique first letters from Product names and Customer names:");
            foreach (var ch in uniqueFirstLetters)
            {
                Debug.WriteLine(ch);
            }
        }

        public void IntersectNumberAAndNumberB(int[] numbersA, int[] numbersB)
        {
            var commonNumbers = numbersA.Intersect(numbersB);

            Debug.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                Debug.WriteLine(n);
            }
        }

        public void ExceptFirstLettersInCustomerNamesButInProductNames(List<Product> products, List<Customer> customers)
        {
            var productFirstLetters = products.Select(prod => prod.Name.First());
            var customerFirstLetters = customers.Select(cust => cust.CompanyName.First());

            var productOnlyFirstChars = productFirstLetters.Except(customerFirstLetters);


            Debug.WriteLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                Debug.WriteLine(ch);
            }
        }
    }
}
