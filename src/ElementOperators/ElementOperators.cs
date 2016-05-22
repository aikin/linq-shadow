using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq.Shadow.Common;

namespace ElementOperators
{
    public class ElementOperators
    {
        public void FirstElementStartsWithOLetter(string[] digits)
        {
            var startsWithO = digits.First(s => s[0] == 'o');

            Debug.WriteLine("A string starting with 'o': {0}", startsWithO);
        }

        public void FirstDefaultWhenNoElements()
        {
            int[] numbers = { };

            var firstNumOrDefault = numbers.FirstOrDefault();

            Debug.WriteLine(firstNumOrDefault);
        }

        public void FisrtDefaultProductWhichProductIdIs789(List<Product> products)
        {
            var product789 = products.FirstOrDefault(p => p.Id == 789);

            Debug.WriteLine("Product 789 exists: {0}", product789 != null);
        }

        public void RetrieveSecondNumberGreaterThan5(int[] numbers)
        {
            var fourthLowNum = numbers.Where(num => num > 5).ElementAt(1);

            Debug.WriteLine("Second number > 5: {0}", fourthLowNum);
        }
    }
}
