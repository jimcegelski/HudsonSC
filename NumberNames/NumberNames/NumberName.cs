namespace NumberNames
{
    public class NumberName
    {
        private static readonly string[] Ones = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        private static readonly string[] Teens = new[]
        {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        private static readonly string[] Tens = new[]
        {"aughts", "teens", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

        public static string GetNumberName(int numberToTest)
        {
            var result = string.Empty;
            if (numberToTest > 99)
            {
                var hundredsPlace = numberToTest/100;
                result += Ones[hundredsPlace] + " hundred";
                numberToTest = numberToTest - (hundredsPlace * 100);
                if (numberToTest > 0) result += " and ";
            }
            if (numberToTest > 19)
            {
                var tensPlace = numberToTest/10;
                result += Tens[tensPlace];
                numberToTest = numberToTest - (tensPlace * 10);
                if (numberToTest > 0) result += " ";
            }
            if (numberToTest < 10)
            {
                if (numberToTest > 0)
                {
                    result += Ones[numberToTest];
                }
                return result;
            }
            return result += Teens[numberToTest - 10];
        }
    }
}
