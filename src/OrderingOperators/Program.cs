using Linq.Shadow.Common;

namespace OrderingOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orderingOperators = new OrderingOperators();

            /*
                This sample uses orderby to sort a list of products by name. 
                Use the "descending" keyword at the end of the clause to perform a reverse ordering.
            */
            orderingOperators.SortProductsByNameLinq(DataProvider.GivenProducts());
            orderingOperators.SortProductsByNameLambda(DataProvider.GivenProducts());


            /*
                This sample uses an OrderBy clause with a custom comparer to do a case-insensitive 
                sort of the words in an array.
            */
            orderingOperators.SortWordsByCustomComparerLambda(DataProvider.GivenWords());


            /*
                This sample uses orderby to sort a list of products by units in stock from highest to lowest.
            */
            orderingOperators.SortProductsByStockLinq(DataProvider.GivenProducts());
            orderingOperators.SortProductsByStockLambda(DataProvider.GivenProducts());


            /*
                This sample uses method syntax to call OrderByDescending because it enables you to use a custom comparer.
            */
            orderingOperators.SortWordsDescByCustomComparerLambda(DataProvider.GivenWords());


            /*
                This sample uses orderby to sort a list of products by name. 
                Use the "descending" keyword at the end of the clause to perform a reverse ordering.
            */


        }
    }
}
