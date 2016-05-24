using Linq.Shadow.Common;

namespace MiscellaneousOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var miscellaneousOperators = new MiscellaneousOperators();


            /*
                This sample uses Concat to create one sequence that contains each array's values, one after the other.
            */
            miscellaneousOperators.ConcatArrayOneAfterTheOther(DataProvider.GivenNumbersA(), DataProvider.GivenNumbersB());


            /*
                This sample uses SequenceEquals to see if two sequences match on all elements in the same order.
            */
            miscellaneousOperators.CompareTwoSequencesAllElementsInSameOrder(DataProvider.GivenWords(), DataProvider.GivenWords());

        }
    }
}
