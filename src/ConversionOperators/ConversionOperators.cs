using System;
using System.Diagnostics;
using System.Linq;

namespace ConversionOperators
{
    public class ConversionOperators
    {
        public void ConvertToArray(double[] doubles)
        {
            var doublesArray = doubles.OrderByDescending(d => d).ToArray();

            Debug.WriteLine("Every other double from highest to lowest:");
            for (var d = 0; d < doublesArray.Length; d += 2)
            {
                Debug.WriteLine(doublesArray[d]);
            }
        }

        public void ConvertToList(string[] words)
        {
            var wordList = words.OrderBy(w => w).ToList();

            Debug.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Debug.WriteLine(w);
            }
        }

        public void ConvertToDictionary()
        {
            var scoreRecords = new[]
            {
                new { Name = "Alice", Score = 50  },
                new { Name = "Bob", Score = 40 },
                new { Name = "Cathy", Score = 45 }
            };

            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

            Debug.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
        }

        public void FilterOfType()
        {
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            var doubles = numbers.OfType<double>();

            Debug.WriteLine("Numbers stored as doubles:");
            foreach (var d in doubles)
            {
                Debug.WriteLine(d);
            }
        }
    }
}