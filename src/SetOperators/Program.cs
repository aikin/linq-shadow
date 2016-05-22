using Linq.Shadow.Common;

namespace SetOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var setOperators = new SetOperators();


            /*
                This sample uses Distinct to remove duplicate elements in a sequence of factors of 300.
            */
            setOperators.UniqueDuplicateFactorsOf300(DataProvider.GivenFactorsOf300());


            /*
                This sample uses Distinct to find the unique Category names.
            */
            setOperators.UniqueCategoryNames(DataProvider.GivenProducts());


            /*
                This sample uses the Union method to create one sequence that contains the unique first letter from both product and 
                customer names. Union is only available through method syntax.
            */
            setOperators.UnionFistLetterFromCustomerNamesAndProductNames(DataProvider.GivenProducts(), DataProvider.GivenCustomers());


            /*
                This sample uses Intersect to create one sequence that contains the common values shared by both arrays.
            */
            setOperators.IntersectNumberAAndNumberB(DataProvider.GivenNumbersA(), DataProvider.GivenNumbersB());



            /*
                This sample uses Except to create one sequence that contains the first letters of product names that 
                are not also first letters of customer names.
            */
            setOperators.ExceptFirstLettersInCustomerNamesButInProductNames(DataProvider.GivenProducts(), DataProvider.GivenCustomers());
        }
    }
}
