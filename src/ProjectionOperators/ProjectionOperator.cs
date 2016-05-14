using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    public class ProjectionOperator
    {
        public ProjectionOperator()
        {
        }

        public List<int> PlusOneForEachItemLinq(int[] numbers)
        {
            var numbersPlusOne = 
                from n in numbers 
                select n + 1;

            Debug.WriteLine("Numbers + 1: ");

            foreach (var num in numbersPlusOne)
            {
                Debug.WriteLine(num);
            }

            return numbersPlusOne.ToList();
        }

        public void PlusOneForEachItemLambda(int[] numbers)
        {
            var numbersPlusOne = numbers.Select(num => num + 1);
            Debug.WriteLine("Numbers + 1: ");

            foreach (var num in numbersPlusOne)
            {
                Debug.WriteLine(num);                
            }
        }

        public void SelectNamesOfProductsLinq(List<Product> products)
        {
            var productNames = 
                from product in products
                select product.Name;

            Debug.WriteLine("product names:");

            foreach (var productName in productNames)
            {
                Debug.WriteLine(productName);
            }
        }

        public void SelectNamesOfProductsLambda(List<Product> products)
        {
            var productNames = products.Select(product => product.Name);

            Debug.WriteLine("product names:");

            foreach (var productName in productNames)
            {
                Debug.WriteLine(productName);
            }
        }

        public void TransformNumberToTextLinq(int[] numbers, string[] strings)
        {
            var textNums =
                from n in numbers
                select strings[n];

            Debug.WriteLine("Numebr Strings: ");

            foreach (var textNum in textNums)
            {
                Debug.WriteLine(textNum);
            }
        }

        public void TransformNumberToTextLambda(int[] numbers, string[] strings)
        {
            var textNums = numbers.Select(n => strings[n]);

            Debug.WriteLine("Numebr Strings: ");

            foreach (var textNum in textNums)
            {
                Debug.WriteLine(textNum);
            }
        }


        public void GenerateUpperLowerWordsLinq(string[] words)
        {
            var upperLowerWords =
                from word in words
                select new {Upper = word.ToUpper(), Lower = word.ToLower()};

            foreach (var upperLowerWord in upperLowerWords)
            {
                Debug.WriteLine("Uppercase: {0}, Lowercase: {1}", upperLowerWord.Upper, upperLowerWord.Lower);
            }
        }
    
        public void GenerateUpperLowerWordsLambda(string[] words)
        {
            var upperLowerWords = words.Select(word => new
            {
                Upper = word.ToUpper(), Lower = word.ToLower()
            });

            foreach (var upperLowerWord in upperLowerWords)
            {
                Debug.WriteLine("Uppercase: {0}, Lowercase: {1}", upperLowerWord.Upper, upperLowerWord.Lower);
            }
        }

        public void GenerateDigitOddEvensLinq(int[] numbers, string[] strings)
        {
            var digitOddEvens =
                from number in numbers
                select new { Digit = strings[number], Even = number % 2 == 0 };

            foreach (var digitOddEven in digitOddEvens)
            {
                Debug.WriteLine("The digit {0} is {1}.", digitOddEven.Digit, digitOddEven.Even ? "even" : "odd");
            }
        }

        public void GenerateDigitsOddEvensLambda(int[] numbers, string[] strings)
        {
            var digitOddEvens = numbers.Select(number => new
            {
                Digit = strings[number], Even = number % 2 == 0
            });

            foreach (var digitOddEven in digitOddEvens)
            {
                Debug.WriteLine("The digit {0} is {1}.", digitOddEven.Digit, digitOddEven.Even ? "even" : "odd");
            }
        }


        public void GenerateProductInfosLambda(List<Product> products)
        {
            var productInfos = products.Select(product => new
            {
                product.Name,
                product.Category,
                Price = product.UnitPrice
            });

            Debug.WriteLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.", 
                    productInfo.Name, productInfo.Category, productInfo.Price);
            }
        }

        public void GenerateProductInfosLinq(List<Product> products)
        {
            var productInfos =
                from product in products
                select new { product.Name, product.Category, Price = product.UnitPrice};

            Debug.WriteLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    productInfo.Name, productInfo.Category, productInfo.Price);
            }
        }
    }
}