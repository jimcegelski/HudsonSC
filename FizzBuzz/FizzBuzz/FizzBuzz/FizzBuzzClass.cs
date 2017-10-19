using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace FizzBuzzProject
{
    public class FizzBuzzClass
    {
        public List<string> FizzBuzz()
        {
            var myList = new List<string>();
            for (var i = 1; i <= 100; i++)
            {
                if (IsNotDivisible(i, 15, "FizzBuzz", myList) &&
                    IsNotDivisible(i, 5, "Buzz", myList) &&
                    IsNotDivisible(i, 3, "Fizz", myList))
                myList.Add(i.ToString());
            }
            return myList;
        }

        private bool IsNotDivisible(int indexNumber,int divisor, string wordToReplaceWith, List<string> myList)
        {
            if (NumberIsDivisibleBy(indexNumber, divisor))
            {
                myList.Add(wordToReplaceWith);
                return false;
            }
            return true;
        }

        private bool NumberIsDivisibleBy(int number, int divisor)
        {
            return (number % divisor == 0);
        }


    }
}
