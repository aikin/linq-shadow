using System.Diagnostics;
using System.Linq;

namespace MiscellaneousOperators
{
    public class MiscellaneousOperators
    {
        public void ConcatArrayOneAfterTheOther(int[] numbersA, int[] numbersB)
        {
            var allNumbers = numbersA.Concat(numbersB);

            Debug.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Debug.WriteLine(n);
            }
        }

        public void CompareTwoSequencesAllElementsInSameOrder(string[] wordsA, string[] wordsB)
        {

            var match = wordsA.SequenceEqual(wordsB);

            Debug.WriteLine($"The sequences match: {match}");
        }
    }
}
