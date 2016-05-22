using System.Diagnostics;
using System.Linq;

namespace GenerationOperators
{
    public class GenerationOperators
    {
        public void GenerateNumbersFrom100to149()
        {
            var numbers = Enumerable.Range(100, 50).Select(num => new { Number = num, OddEven = num % 2 == 1 ? "odd" : "even" });

            foreach (var n in numbers)
            {
                Debug.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }

        public void GenerateRepeatNumber7()
        {
            var numbers = Enumerable.Repeat(7, 10);

            foreach (var n in numbers)
            {
                Debug.WriteLine(n);
            }
        }
    }
}
