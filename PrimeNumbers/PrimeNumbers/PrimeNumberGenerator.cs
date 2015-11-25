using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumberGenerator
    {
        public static int[] GetPrimeFactors(int number)
        {
            var list = GetFactors(number);
            return list.Count > 0 ? list.ToArray() : new[] {number};
        }

        private static List<int> GetFactors(int number)
        {
            var results = new List<int>();
            for (var i = 2; i <= (number/2); i++)
            {
                if (number % i != 0) continue;

                AddNumberToFactorsList(i, results);
                AddNumberToFactorsList(number/i, results);

                break;
            }
            return results;
        }

        private static void AddNumberToFactorsList(int i, List<int> results)
        {
            if (IsPrime(i))
            {
                results.Add(i);
            }
            else
            {
                results.AddRange(GetFactors(i));
            }
        }

        private static bool IsPrime(int number)
        {
            for (var i = 2; i < number; i++)
            {
                if (number%i == 0) return false;
            }
            return true;
        }             
    }
}
