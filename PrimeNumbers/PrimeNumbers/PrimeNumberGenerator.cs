using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumberGenerator
    {
        public static int[] GetPrimeFactors(int number)
        {
            var list = new List<int>();
            for (var i = 2; i < number; i++)
            {
                if (number%i == 0)
                {
                    list.Add(i);
                    if (number/i == i)
                    {
                        list.Add(i);
                    }
                }
            }
            if (list.Count > 0) return list.ToArray();
            return new[] {number};

        }
    }
}
