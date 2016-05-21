using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace RestrictionOperators
{
    public class RestrictionOperators
    {
        public void FindNumbersLessThanFiveLinq(int[] numbers)
        {
            var lowNums =
                from num in numbers
                where num < 5
                select num;

            Debug.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Debug.WriteLine(num);
            }
        }

        public void FindNumbersLessThanFiveLambda(int[] numbers)
        {
            var lowNums = numbers.Where(num => num < 5);

            Debug.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Debug.WriteLine(num);
            }
        }

    }
}