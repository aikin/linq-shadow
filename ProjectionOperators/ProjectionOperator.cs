using System;
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

        public void PlusOneForEachItemLinq(int[] numbers)
        {
            var numbersPlusOne = 
                from n in numbers 
                select n + 1;

            Debug.WriteLine("Numbers + 1: ");

            foreach (var num in numbersPlusOne)
            {
                Debug.WriteLine(num);
            }
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

        public void TransformationNumberToTextLinq(int[] numbers, string[] strings)
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

        public void TransformationNumberToTextLambda(int[] numbers, string[] strings)
        {
            var textNums = numbers.Select(n => strings[n]);

            Debug.WriteLine("Numebr Strings: ");

            foreach (var textNum in textNums)
            {
                Debug.WriteLine(textNum);
            }
        }
    }
}