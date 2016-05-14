﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectionOperators
{
    public class ProjectionOperator
    {
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
                Upper = word.ToUpper(),
                Lower = word.ToLower()
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
                select new {Digit = strings[number], IsEven = number%2 == 0};

            foreach (var digitOddEven in digitOddEvens)
            {
                Debug.WriteLine("The digit {0} is {1}.", digitOddEven.Digit, digitOddEven.IsEven ? "even" : "odd");
            }
        }

        public void GenerateDigitsOddEvensLambda(int[] numbers, string[] strings)
        {
            var digitOddEvens = numbers.Select(number => new
            {
                Digit = strings[number],
                IsEven = number%2 == 0
            });

            foreach (var digitOddEven in digitOddEvens)
            {
                Debug.WriteLine("The digit {0} is {1}.", digitOddEven.Digit, digitOddEven.IsEven ? "even" : "odd");
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
                select new {product.Name, product.Category, Price = product.UnitPrice};

            Debug.WriteLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                Debug.WriteLine("{0} is in the category {1} and costs {2} per unit.",
                    productInfo.Name, productInfo.Category, productInfo.Price);
            }
        }

        public void DetermineNumberIsInPlaceLambda(int[] numbers)
        {
            var numsInPlace = numbers.Select((num, index) => new
            {
                Num = num,
                IsInPlace = num == index
            });

            Debug.WriteLine("Number: In-place?");
            foreach (var num in numsInPlace)
            {
                Debug.WriteLine("{0}: {1}", num.Num, num.IsInPlace);
            }
        }

        public void FilteredEachTextDigitLessThanFiveLinq(int[] numbers, string[] strings)
        {
            var lowNums =
                from num in numbers
                where num < 5
                select strings[num];

            Debug.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Debug.WriteLine(num);
            }
        }

        public void FilteredEachTextDigitLessThanFiveLambda(int[] numbers, string[] strings)
        {
            var lowNums = numbers
                .Where(num => num < 5)
                .Select(num => strings[num]);

            Debug.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Debug.WriteLine(num);
            }
        }

        public void CompoundPairsFromNumbersALessThanNumbersBLinq(int[] numbersA, int[] numbersB)
        {
            var pairs =
                from numA in numbersA
                from numB in numbersB
                where numA < numB
                select new {numA = numA, numB = numB};

            Debug.WriteLine("Pairs where numA < numB:");
            foreach (var pair in pairs)
            {
                Debug.WriteLine("{0} is less than {1}", pair.numA, pair.numB);
            }
        }

        public void CompoundPairsFromNumbersALessThanNumbersBLambda(int[] numbersA, int[] numbersB)
        {
            var pairs = numbersA
                .SelectMany(numA => numbersB, (numA, numB) => new {numA, numB})
                .Where(@t => @t.numA < @t.numB);
//                .Select(@t => new {numA = @t.numA, numB = @t.numB});

            Debug.WriteLine("Pairs where numA < numB:");
            foreach (var pair in pairs)
            {
                Debug.WriteLine("{0} is less than {1}", pair.numA, pair.numB);
            }
        }
    }
}