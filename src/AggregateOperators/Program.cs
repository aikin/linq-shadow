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


        }
    }
}
