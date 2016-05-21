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
                This sample uses TakeWhile to return elements starting from the beginning of the array until a number is read whose value is not less than 6.
            */
            partitioningOperators.TakeNumbersUntilNumberLessThanSix(DataProvider.GivenNumbers());


            /*
                This sample uses TakeWhile to return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            */
            partitioningOperators.TakWhileNumberLessThanItPosition(DataProvider.GivenNumbers());


            /*
                This sample uses SkipWhile to get the elements of the array starting from the first element divisible by 3.
            */
            partitioningOperators.SkipWhileFirstNumberDivisble3(DataProvider.GivenNumbers());


            /*
                This sample uses SkipWhile to get the elements of the array starting from the first element less than its position.
            */
            partitioningOperators.SkipWhileFirstNumberLessThanItsPosition(DataProvider.GivenNumbers());
        }
    }
}
