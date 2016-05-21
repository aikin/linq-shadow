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
                This sample uses the where clause to find all customers in Washington and 
                then it uses a foreach loop to iterate over the orders collection that belongs to each customer.
            */
            restrictionOperators.FindCustombersInWashingtonLinq(DataProvider.GivenCustomers());
            restrictionOperators.FindCustombersInWashingtonLambda(DataProvider.GivenCustomers());


            /*
                This sample demonstrates an indexed where clause that returns digits whose name 
                is shorter than their value.
            */
            restrictionOperators.FindDigitsWhoseNameIsShorterThanTheirValueLambda(DataProvider.GivenDigits());
        }
    }
}
