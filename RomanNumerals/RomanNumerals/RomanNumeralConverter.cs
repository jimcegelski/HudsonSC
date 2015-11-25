using System;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public static string Convert(int numberToConvert)
        {
            var romanNumeral = string.Empty;
            AccountForValue(10, "X", ref romanNumeral, ref numberToConvert);
            AccountForValue(9, "IX", ref romanNumeral, ref numberToConvert);
            AccountForValue(5, "V", ref romanNumeral, ref numberToConvert);
            AccountForValue(4, "IV", ref romanNumeral, ref numberToConvert);
            while (numberToConvert > 0)
            {
                AccountForValue(1, "I", ref romanNumeral, ref numberToConvert);
            }
            return romanNumeral;
        }

        private static void AccountForValue(int number, string romanNumeralRepresentation, ref string romanNumeral,
            ref int numberToConvert)
        {
            if (numberToConvert < number) return;
            romanNumeral += romanNumeralRepresentation;
            numberToConvert = numberToConvert - number;
        }

    }
}
