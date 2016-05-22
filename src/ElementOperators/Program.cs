using Linq.Shadow.Common;

namespace ElementOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var elementOperators = new ElementOperators();


            /*
                This sample uses First to find the first element in the array that starts with 'o'.
            */
            elementOperators.FirstElementStartsWithOLetter(DataProvider.GivenDigits());


            /*
                This sample uses FirstOrDefault to try to return the first element of the sequence, unless there are 
                no elements, in which case the default value for that type is returned. FirstOrDefault is useful 
                for creating outer joins.
            */
            elementOperators.FirstDefaultWhenNoElements();



            /*
                This sample uses FirstOrDefault to return the first product whose ProductID is 789 as a 
                single Product object, unless there is no match, in which case null is returned.
            */
            elementOperators.FisrtDefaultProductWhichProductIdIs789(DataProvider.GivenProducts());



            /*
                This sample uses ElementAt to retrieve the second number greater than 5 from an array.
            */
            elementOperators.RetrieveSecondNumberGreaterThan5(DataProvider.GivenNumbers());

        }
    }
}
