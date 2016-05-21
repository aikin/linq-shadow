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


            /*
                This sample uses the where clause to find all products that are out of stock.
            */
            restrictionOperators.FindOutOfStockProductsLinq(DataProvider.GivenProducts());
            restrictionOperators.FindOutOfStockProductsLambda(DataProvider.GivenProducts());


            /*
                This sample uses the where clause to find all products that are in stock and cost more than 3.00 per unit.
            */
            restrictionOperators.FindCostMoreThanThreePerUnitProductsLinq(DataProvider.GivenProducts());
            restrictionOperators.FindCostMoreThanThreePerUnitProductsLambda(DataProvider.GivenProducts());


            /*
                This sample uses the where clause to find all products that are out of stock.
            */



            /*
                This sample uses the where clause to find all products that are out of stock.
            */



            /*
                This sample uses the where clause to find all products that are out of stock.
            */

        }
    }
}
