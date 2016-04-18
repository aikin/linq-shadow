using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectionOperator = new ProjectionOperator();

            projectionOperator.PlusOneForEachItemLinq(DataProvider.GivenNumbers());
            projectionOperator.PlusOneForEachItemLambda(DataProvider.GivenNumbers());
        }
    }
}
