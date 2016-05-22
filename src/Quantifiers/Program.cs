using Linq.Shadow.Common;

namespace Quantifiers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var quantifiers = new Quantifiers();

            /*
                This sample uses Any to determine if any of the words in the array contain the substring 'ei'.
            */
            quantifiers.DetermineWordsContainEI(DataProvider.GivenWords());

            /*
                This sample uses Any to return a grouped a list of products only for categories that 
                have at least one product that is out of stock.
            */
            quantifiers.GroupProductsHaveAtLeastOneProduct(DataProvider.GivenProducts());


            /*
                This sample uses All to return a grouped a list of products only for categories that 
                have all of their products in stock.
            */
            quantifiers.GroupProductsAllInStock(DataProvider.GivenProducts());
        }
    }
}
