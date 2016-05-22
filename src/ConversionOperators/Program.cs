using Linq.Shadow.Common;

namespace ConversionOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conversionOperators = new ConversionOperators();

            /*  
                This sample uses ToArray to immediately evaluate a sequence into an array.
            */
            conversionOperators.ConvertToArray(DataProvider.GivenDoubles());


            /*  
                This sample uses ToList to immediately evaluate a sequence into a List.
            */
            conversionOperators.ConvertToList(DataProvider.GivenWords());


            /*  
                This sample uses ToDictionary to immediately evaluate a sequence and a related key expression into a dictionary.
            */
            conversionOperators.ConvertToDictionary();


            /*  
                This sample uses OfType to return only the elements of the array that are of type double.
            */
            conversionOperators.FilterOfType();


        }
    }
}
