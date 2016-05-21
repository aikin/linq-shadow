using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Shadow.Common;

namespace PartitioningOperators
{
    public class PartitioningOperators
    {
        public void TakeToGetTheFirst3OrdersFromCustomersInWashingtonLinq(List<Customer> customers, List<Order> orders)
        {
            var first3WAOrders = (
                from cust in customers
                from order in orders
                where cust.Region == "WA" && cust.Id == order.CustomerId
                select new
                {
                    CustomerId = cust.Id,
                    OrderId = order.Id,
                    OrderDate = order.OrderDate
                })
                .Take(3);

            Debug.WriteLine("First 3 orders in WA:");            
            foreach (var order in first3WAOrders)
            {
                Debug.WriteLine("CustomerID={0}  OrderID={1}  OrderDate={2}",
                    order.CustomerId, order.OrderId, order.OrderDate);
            }
        }
        public void TakeToGetTheFirst3OrdersFromCustomersInWashingtonLambda(List<Customer> customers, List<Order> orders)
        {
            var first3WAOrders = customers
                .SelectMany(cust => orders, (cust, order) => new {cust, order})
                .Where(@t => @t.cust.Region == "WA" && @t.cust.Id == @t.order.CustomerId)
                .Select(@t => new
                {
                    CustomerId = @t.cust.Id,
                    OrderId = @t.order.Id,
                    OrderDate = @t.order.OrderDate
                })
                .Take(3);

            Debug.WriteLine("First 3 orders in WA:");            
            foreach (var order in first3WAOrders)
            {
                Debug.WriteLine("CustomerID={0}  OrderID={1}  OrderDate={2}",
                    order.CustomerId, order.OrderId, order.OrderDate);
            }
        }

        public void SkipFirstFourNumbers(int[] numbers)
        {

            var allButFirst4Numbers = numbers.Skip(4);

            Debug.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Debug.WriteLine(n);
            }
        }

        public void TakeNumbersUntilNumberLessThanSix(int[] numbers)
        {
            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Debug.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Debug.WriteLine(num);
            }
        }

        public void TakWhileNumberLessThanItPosition(int[] numbers)
        {
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

            Debug.WriteLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                Debug.WriteLine(n);
            }
        }

        public void SkipWhileFirstNumberDivisble3(int[] numbers)
        {
            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            Debug.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                Debug.WriteLine(n);
            }
        }

        public void SkipWhileFirstNumberLessThanItsPosition(int[] numbers)
        {
            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

            Debug.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                Debug.WriteLine(n);
            }
        }
    }
}