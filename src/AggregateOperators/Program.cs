using Linq.Shadow.Common;

namespace AggregateOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var aggregateOperators = new AggregateOperators();

            /*
                This sample uses Count to get the number of odd ints in the array.
            */
            aggregateOperators.CountOddNumbers(DataProvider.GivenNumbers());


            /*
                This sample uses Count to return a list of customers and how many orders each has.
            */
            aggregateOperators.CountCustomerOrders(DataProvider.GivenCustomers(), DataProvider.GivenOrders());


            /*
                This sample uses Count to return a list of categories and how many products each has.
            */
            aggregateOperators.CountProductsInEachCategory(DataProvider.GivenProducts());


            /*
                This sample uses Sum to get the total number of characters of all words in the array.
            */
            aggregateOperators.SumTotalCharsOfAllWords(DataProvider.GivenWords());


            /*
                This sample uses Sum to get the total units in stock for each product category.
            */
            aggregateOperators.SumTotalUnitsInStockForEachProductCategory(DataProvider.GivenProducts());


            /*
                This sample uses Min to get the cheapest price among each category's products.
            */
            aggregateOperators.MinCheapestCategoryProducts(DataProvider.GivenProducts());


            /*
                This sample uses Min to get the products with the lowest price in each category.
            */
            aggregateOperators.MinPriceInEachCategory(DataProvider.GivenProducts());


            /*
                This sample uses Max to get the length of the longest word in an array.
            */
            aggregateOperators.MaxWordHasLongLength(DataProvider.GivenWords());



            /*
                This sample uses Average to get the average of all numbers in an array.
            */
            aggregateOperators.AverageAllNumbers(DataProvider.GivenNumbers());


            /*
                This sample uses Aggregate to create a running product on the array that calculates the total product of all elements.
            */
            aggregateOperators.AggregateCalculateTotal(DataProvider.GivenDoubles());



            /*
                This sample uses Aggregate to create a running account balance that subtracts each withdrawal from the initial balance of 100, as long as the balance never drops below 0.
            */
            aggregateOperators.AggregateSubWithdrawalsInitWith100(DataProvider.GivenWithdrawals(), 100.0);
        }
    }
}