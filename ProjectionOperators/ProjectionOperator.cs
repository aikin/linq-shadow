using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    public class ProjectionOperator
    {
        public ProjectionOperator()
        {
        }

        public void PlusOneForEachItemLinq(int[] numbers)
        {
            var numbersPlusOne = 
                from n in numbers 
                select n + 1;

            Debug.WriteLine("Numbers + 1: ");

            foreach (var num in numbersPlusOne)
            {
                Debug.WriteLine(num);
            }
        }

        public void PlusOneForEachItemLambda(int[] numbers)
        {
            var numbersPlusOne = numbers.Select(num => num + 1);
            Debug.WriteLine("Numbers + 1: ");

            foreach (var num in numbersPlusOne)
            {
                Debug.WriteLine(num);                
            }
        }
    }
}