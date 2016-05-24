using System.Diagnostics;
using System.Linq;

namespace QueryExecution
{
    public class QueryExecution
    {
        public void ImmediateExecution(int[] numbers)
        {
            // Methods like ToList(), Max(), and Count() cause the query to be
            // executed immediately.            
            var i = 0;
            var immediateQuery = numbers.Select(num => ++i).ToList();

            Debug.WriteLine("The current value of i is {0}", i); //i has been incremented

            foreach (var item in immediateQuery)
            {
                Debug.WriteLine("v = {0}, i = {1}", item, i);
            }
        }

        public void DeferredExecution(int[] numbers)
        {
            var i = 0;
            var simpleQuery = numbers.Select(num => ++i);

            // The local variable 'i' is not incremented
            // until the query is executed in the foreach loop.
            Debug.WriteLine("The current value of i is {0}", i); //i is still zero

            foreach (var item in simpleQuery)
            {
                Debug.WriteLine("v = {0}, i = {1}", item, i); // now i is incremented          
            }
        }

        public void QueryReuse(int[] numbers)
        {
            // Deferred execution lets us define a query once
            // and then reuse it later in various ways.
            var lowNumbers = numbers.Where(num => num <= 3);

            Debug.WriteLine("First run numbers <= 3:");
            foreach (var n in lowNumbers)
            {
                Debug.WriteLine(n);
            }

            // Query the original query.
            var lowEvenNumbers = lowNumbers.Where(p => p % 2 == 0);

            Debug.WriteLine("Run lowEvenNumbers query:");
            foreach (var n in lowEvenNumbers)
            {
                Debug.WriteLine(n);
            }


            // Modify the source data.
            for (var i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object,
            // lowNumbers, will be iterating over the new state
            // of numbers[], producing different results:
            Debug.WriteLine("Second run numbers <= 3:");
            foreach (var n in lowNumbers)
            {
                Debug.WriteLine(n);
            }

        }
    }
}
