using System;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty) return 0;

            var delimiterVar = "\n";
            if (numbers.StartsWith("//"))
            {
                if (numbers.Contains("["))
                {
                    var delimiters = numbers.Substring(2, numbers.IndexOf("\n") - 2);
                    numbers = numbers.Substring(numbers.IndexOf("\n") + 2);
                    while (delimiters.Contains("["))
                    {
                        var delimiter = delimiters.Substring(1, delimiters.IndexOf("]") - 1);
                        numbers = numbers.Replace(delimiter, ",");
                        delimiters = delimiters.Replace("[" + delimiter + "]", "");
                    }
                }
                else
                {
                    var nIndex = numbers.IndexOf("\n");
                    delimiterVar = numbers.Substring(2, nIndex - 2);
                    numbers = numbers.Substring(nIndex + 2);
                }

            }

            numbers = numbers.Replace(delimiterVar, ",");

            var numberArray = numbers.Split(',');
            var numberArrayDos = new int[numberArray.Length];

            for (var i = 0; i < numberArray.Length; i++)
            {
                numberArrayDos[i] = int.Parse(numberArray[i]);
                if (numberArrayDos[i] > 1000) numberArrayDos[i] = 0;
            }

            var negativeNumbers = numberArrayDos.Where(x => x < 0);
            if (numberArrayDos.Any(x => x < 0))
            {
                var negativeNumberCount = 0;
                var errorMessage = "Negative numbers not allowed [";
                foreach (var number in numberArrayDos)
                {

                    if (number < 0)
                    {
                        negativeNumberCount += 1;
                        if (negativeNumberCount > 1) errorMessage += ", ";
                        errorMessage += number.ToString();
                    }
                }
                throw new Exception(errorMessage + "]");
            }

            //Return the sum of the new array
            return numberArrayDos.Sum();
        }
    }
}
