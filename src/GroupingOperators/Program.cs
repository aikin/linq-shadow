using Linq.Shadow.Common;

namespace GroupingOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var groupingOperators = new GroupingOperators();

            /*
                This sample uses group by to partition a list of products by category.
            */
            groupingOperators.GroupProductsByCategoryLinq(DataProvider.GivenProducts());
            groupingOperators.GroupProductsByCategoryLambda(DataProvider.GivenProducts());

            /*
                This sample uses group by to partition a list of each customer's orders, first by year, and 
                then by month.
            */
            groupingOperators.GroupOrdersByNestedConditionsLinq(DataProvider.GivenCustomers(), DataProvider.GivenOrders());
            groupingOperators.GroupOrdersByNestedConditionsLambda(DataProvider.GivenCustomers(), DataProvider.GivenOrders());



            /*
                This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that 
                matches words that are anagrams of each other.
            */
            groupingOperators.GroupWordsByCustomAnagramComparerLambda(DataProvider.GivenAnagramWords());



            /*
                This sample uses group by to partition a list of products by category.
            */
        }
    }
}
