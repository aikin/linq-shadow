﻿using System;
using System.Collections.Generic;
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
    }
}