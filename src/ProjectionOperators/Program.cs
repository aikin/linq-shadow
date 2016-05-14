using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectionOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var projectionOperator = new ProjectionOperator();

            /*
                This sample uses select to produce a sequence of 
                ints one higher than those in an existing array of ints.
            */
            projectionOperator.PlusOneForEachItemLinq(DataProvider.GivenNumbers());
            projectionOperator.PlusOneForEachItemLambda(DataProvider.GivenNumbers());


            /* 
                This sample uses select to return a sequence of just the names of a list of products.
            */
            projectionOperator.SelectNamesOfProductsLinq(DataProvider.GivenProducts());
            projectionOperator.SelectNamesOfProductsLambda(DataProvider.GivenProducts());


            /* This sample uses select to produce a sequence of 
               strings representing the text version of a sequence of ints.
            */
            projectionOperator.TransformNumberToTextLinq(DataProvider.GivenNumbers(), DataProvider.GivenStrings());
            projectionOperator.TransformNumberToTextLambda(DataProvider.GivenNumbers(), DataProvider.GivenStrings());


            /*
                This sample uses select to produce a sequence of 
                the uppercase and lowercase versions of each word in the original array.
            */
            projectionOperator.GenerateUpperLowerWordsLinq(DataProvider.GivenWords());
            projectionOperator.GenerateUpperLowerWordsLambda(DataProvider.GivenWords());


            /* This sample uses select to produce a sequence containing text representations of 
                digits and whether their length is even or odd. 
            */
            projectionOperator.GenerateDigitOddEvensLinq(DataProvider.GivenNumbers(), DataProvider.GivenStrings());
            projectionOperator.GenerateDigitsOddEvensLambda(DataProvider.GivenNumbers(), DataProvider.GivenStrings());


            /*
                This sample uses select to produce a sequence containing some properties of
                Products, including UnitPrice which is renamed to Price in the resulting type.
            */
            projectionOperator.GenerateProductInfosLinq(DataProvider.GivenProducts());
            projectionOperator.GenerateProductInfosLambda(DataProvider.GivenProducts());


            /*
                This sample uses an indexed Select clause to determine if the value of ints in an array match their position in the array.
            */
            projectionOperator.DetermineNumberIsInPlaceLambda(DataProvider.GivenNumbers());


            /* 
                This sample combines select and where to make a simple query 
                that returns the text form of each digit less than 5. 
            */
            projectionOperator.FilteredEachTextDigitLessThanFiveLinq(DataProvider.GivenNumbers(), DataProvider.GivenStrings());
            projectionOperator.FilteredEachTextDigitLessThanFiveLambda(DataProvider.GivenNumbers(), DataProvider.GivenStrings());
        }
    }
}
