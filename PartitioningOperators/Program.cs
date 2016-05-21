using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Shadow.Common;

namespace PartitioningOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var partitioningOperators = new PartitioningOperators();

            /*
                This sample uses Take to get the first 3 orders from customers in Washington.
            */
            partitioningOperators.TakeToGetTheFirst3OrdersFromCustomersInWashingtonLinq(DataProvider.GivenCustomers(), DataProvider.GivenOrders());
            partitioningOperators.TakeToGetTheFirst3OrdersFromCustomersInWashingtonLambda(DataProvider.GivenCustomers(), DataProvider.GivenOrders());


            /*
                This sample uses Skip to get all but the first four elements of the array.
            */
            partitioningOperators.SkipFirstFourNumbers(DataProvider.GivenNumbers());


            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */
            /*
                This sample uses Take to get only the first 3 elements of the array
            */

        }
    }
}
