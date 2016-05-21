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


        }
    }
}
