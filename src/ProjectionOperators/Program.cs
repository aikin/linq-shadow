using System;

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
                This sample uses an indexed Select clause to determine if the value of 
                ints in an array match their position in the array.
            */
            projectionOperator.DetermineNumberIsInPlaceLambda(DataProvider.GivenNumbers());


            /* 
                This sample combines select and where to make a simple query 
                that returns the text form of each digit less than 5. 
            */
            projectionOperator.FilteredEachTextDigitLessThanFiveLinq(DataProvider.GivenNumbers(), DataProvider.GivenStrings());
            projectionOperator.FilteredEachTextDigitLessThanFiveLambda(DataProvider.GivenNumbers(), DataProvider.GivenStrings());


            /*
                This sample uses a compound from clause to make a query that returns all pairs of
                numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            */
            projectionOperator.CompoundPairsFromNumbersALessThanNumbersBLinq(DataProvider.GivenNumbersA(), DataProvider.GivenNumbersB());
            projectionOperator.CompoundPairsFromNumbersALessThanNumbersBLambda(DataProvider.GivenNumbersA(), DataProvider.GivenNumbersB());


            /* 
                This sample uses a compound from clause to select all orders where the order total is less than 500.00.
            */
            projectionOperator.CompoundOrdersByOrderTotalLessThanLinq(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), decimal.Parse("500"));
            projectionOperator.CompoundOrdersByOrderTotalLessThanLambda(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), decimal.Parse("500"));

            /* 
                This sample uses a compound from clause to select all orders where the order was made in 1998 or later.
            */
            projectionOperator.CompoundOrdersByOrderDateLaterThanLinq(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), new DateTime(1998, 1, 1));
            projectionOperator.CompoundOrdersByOrderDateLaterThanLambda(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), new DateTime(1998, 1, 1));


            /*
                This sample uses a compound from clause to select all orders where the order total is 
                greater than 2000.00 and uses from assignment to avoid requesting the total twice.
            */
            projectionOperator.CompoundOrdersByOrderTotalGreaterThanLinq(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), decimal.Parse("2000"));
            projectionOperator.CompoundOrdersByOrderTotalGreaterThanLambda(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), decimal.Parse("2000"));


            /*  
                This sample uses multiple from clauses so that filtering on customers can be done before selecting their orders. 
                This makes the query more efficient by not selecting and then discarding orders for customers outside of Washington.
            */
            projectionOperator.CompoundOrdersByOrderDateLaterThanInWashingtonLinq(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), new DateTime(1997, 1, 1));
            projectionOperator.CompoundOrdersByOrderDateLaterThanInWashingtonLabdma(DataProvider.GivenCustomers(), DataProvider.GivenOrders(), new DateTime(1997, 1, 1));

            /*
                This sample uses an indexed SelectMany clause to select all orders, while referring to 
                customers by the order in which they are returned from the query.
            */
            projectionOperator.MappingCustomersIndexForEachOrdersLabdma(DataProvider.GivenCustomers(), DataProvider.GivenOrders());
        }
    }
}
