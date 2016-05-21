using Linq.Shadow.Common;

namespace RestrictionOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var restrictionOperators = new RestrictionOperators();

            /*
                This sample uses the where clause to find all elements of an array with a value less than 5.
            */
            restrictionOperators.FindNumbersLessThanFiveLinq(DataProvider.GivenNumbers());
            restrictionOperators.FindNumbersLessThanFiveLambda(DataProvider.GivenNumbers());

       
        }
    }
}
