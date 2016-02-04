namespace NumberNames
{
    public class NumberName
    {
        private static readonly string[] Ones = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        private static readonly string[] Teens = new[]
        {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        private static readonly string[] Tens = new[]
        {"aughts", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
        
        public static string GetNumberName(int numberToTest)
        {
            return $"{HandleNumber(ref numberToTest, 1000000, " million")}" +
                   $"{HandleNumber(ref numberToTest, 1000, " thousand")}" +
                   $"{HandleNumber(ref numberToTest, 1, "")}";
        }

        public static string HandleNumber(ref int numberToTest, int numberToCheckFor, string numberAsString)
        {
            var result = string.Empty;
            if (numberToTest < numberToCheckFor) return result;
            result = $"{GetNameForHundredsTensAndOnesPlace(numberToTest / numberToCheckFor)}{numberAsString}";
            numberToTest = numberToTest % numberToCheckFor;
            if (numberToTest > 0) result = $"{result}, ";
            return result;
        }

        public static string GetNameForHundredsTensAndOnesPlace(int numberToTest)
        {
            var result = string.Empty;
            ResolveOnePlace(ref numberToTest, 99, 100, " hundred", " and ", Ones, ref result);
            ResolveOnePlace(ref numberToTest, 19, 10, "", " ", Tens, ref result);

            if (numberToTest >= 10) return $"{result}{Teens[numberToTest - 10]}";
            if (numberToTest > 0) result += Ones[numberToTest]; 
            return result;
        }

        public static void ResolveOnePlace(ref int numberToTest, int minNumber, int divNumber, string placeIndetifier,
            string separater, string[] arrayToUse, ref string result)
        {
            if (numberToTest <= minNumber) return;
            var digitPlace = numberToTest/divNumber;
            result = $"{result}{arrayToUse[digitPlace]}{placeIndetifier}";
            numberToTest = numberToTest - (digitPlace*divNumber);
            if (numberToTest > 0) result = $"{result}{separater}";
        }
    }
}