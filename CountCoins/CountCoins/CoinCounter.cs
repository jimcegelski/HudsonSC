using System.Collections.Generic;

namespace CountCoins
{
    public class CoinCounter
    {
        public static List<string> GetCoinCollections(int centsToStartWith)
        {
            var result = new List<string>();
            var coinToStartWith = 10;
            while (coinToStartWith > 0)
            {
                var centsRemaining = centsToStartWith;
                var collection = new Dictionary<int, int>();

                if (coinToStartWith <= centsRemaining)
                {
                    collection[coinToStartWith] = 1;
                    centsRemaining = centsRemaining - coinToStartWith;
                    AddCoinToCollection(coinToStartWith, ref centsRemaining, collection);
                }

                if (collection.Count > 0) result.Add(ConvertCollectionIntoString(collection));

                coinToStartWith = GetNextLowestCoinType(coinToStartWith);
            }
            
            return result;
        }
        
        private static Dictionary<int, int> CreateCoinCollectionStartingWithSpecificCoin(int coinTypeToStartWith,
            int centsToStartWith)
        {
            var collection = new Dictionary<int, int>();
            if (coinTypeToStartWith <= centsToStartWith)
            {
                collection[coinTypeToStartWith] = 1;
                centsToStartWith = centsToStartWith - coinTypeToStartWith;
                AddCoinToCollection(coinTypeToStartWith, ref centsToStartWith, collection);
            }

            return collection;
        }
        
        private static void AddCoinToCollection(int coinTypeToAdd, ref int centsToStartWith, Dictionary<int, int> coinCollection)
        {
            while (centsToStartWith > 0)
            {
                if (coinTypeToAdd > centsToStartWith) coinTypeToAdd = GetNextLowestCoinType(coinTypeToAdd);
                if (!coinCollection.ContainsKey(coinTypeToAdd))
                {
                    coinCollection.Add(coinTypeToAdd, 0);
                }
                coinCollection[coinTypeToAdd] ++;
                centsToStartWith = centsToStartWith - coinTypeToAdd;
            }
        }

        private static string ConvertCollectionIntoString(Dictionary<int, int> coinCollection)
        {
            var result = string.Empty;
            foreach (var coinType in coinCollection.Keys)
            {
                if (result != string.Empty) result += " and ";
                var numberString = ConvertNumberToString(coinCollection[coinType]);
                if (result == string.Empty)
                {
                    result = numberString.ToUpper();
                }
                else
                {
                    result += numberString;
                }
                result += " ";
                result += ConvertCoinType(coinType, coinCollection[coinType]);
            }
            return result;
        }

        public static string ConvertNumberToString(int number)
        {
            if (number == 1) return "a";
            return number.ToString();
        }

        public static string ConvertCoinType(int coinType, int numberOfCoins)
        {
            if (coinType == 1)
            {
                if (numberOfCoins == 1) return "penny";
                return "pennies";
            }
            if (coinType == 5)
            {
                if (numberOfCoins == 1) return "nickel";
                return "nickles";
            }
            if (coinType == 10)
            {
                if (numberOfCoins == 1) return "dime";
                return "dimes";
            }
            return string.Empty;
        }

        public static int GetNextLowestCoinType(int coinType)
        {
            switch (coinType)
            {
                case 10:
                    return 5;
                case 5:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
