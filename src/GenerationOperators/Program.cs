using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var generationOperators = new GenerationOperators();

            /*
                This sample uses Range to generate a sequence of numbers from 100 to 149 that 
                is used to find which numbers in that range are odd and even.
            */
            generationOperators.GenerateNumbersFrom100to149();


            /*
                This sample uses Repeat to generate a sequence that contains the number 7 ten times.
            */
            generationOperators.GenerateRepeatNumber7();


        }
    }
}
