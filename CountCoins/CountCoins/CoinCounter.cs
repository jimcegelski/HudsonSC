using System.Collections.Generic;
using System.Linq;

namespace CountCoins
{
    public class CoinCounter
    {
        public static List<string> GetCoinCollections(int centsToStartWith)
        {
            var results = new List<string>();
            var coinCollection = new Dictionary<int,int>();

            Process(centsToStartWith, centsToStartWith, results, 25, coinCollection);
                
            return results;
        }

        private static void Process(int centsToStartWith, int centsLeftOver, IList<string> results, int coinDenomination, Dictionary<int,int> coinCollection)
        {
            for (var numberOfCoins = 0; numberOfCoins <= centsLeftOver / coinDenomination; numberOfCoins++)
            {
                var newCoinCollection = CloneCollection(coinCollection);
                if (numberOfCoins > 0) AddCoinToCollection(coinDenomination, newCoinCollection, numberOfCoins);

                if (GetNextLowestCoinType(coinDenomination) > int.MinValue)
                    Process(centsToStartWith, centsToStartWith - GetCollectionTotal(newCoinCollection), results, GetNextLowestCoinType(coinDenomination), newCoinCollection);
                
                if (GetCollectionTotal(newCoinCollection) < centsToStartWith) AddCoinToCollection(1, newCoinCollection, centsToStartWith - GetCollectionTotal(newCoinCollection));

                var resultString = ConvertCollectionIntoString(newCoinCollection);
                if (results.IndexOf(resultString) < 0) results.Add(resultString);
            }   
        }

        private static Dictionary<int, int> CloneCollection(Dictionary<int, int> collectionToClone)
        {
            return collectionToClone.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }
        
        private static string ConvertCollectionIntoString(Dictionary<int, int> coinCollection)
        {
            var result = string.Empty;
            var coinList = coinCollection.Keys.ToList();
            coinList.Sort();

            foreach (var coinType in coinList)
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

        //private static string ConvertCollectionIntoNumberString(Dictionary<int, int> coinCollection)
        //{
        //    return
        //        $"{GetNumberOfCoins(25, coinCollection)} {GetNumberOfCoins(10, coinCollection)} {GetNumberOfCoins(5, coinCollection)} {GetNumberOfCoins(1, coinCollection)}";
        //}

        //private static string GetNumberOfCoins(int denomination, Dictionary<int, int> collection)
        //{
        //    if (!collection.ContainsKey(denomination)) return "0";
        //    return collection[denomination].ToString();
        //}

        public static string ConvertNumberToString(int number)
        {
            if (number == 1) return "a";
            return number.ToString();
        }

        public static string ConvertCoinType(int coinType, int numberOfCoins)
        {
            if (numberOfCoins == 1)
            {
                switch (coinType)
                {
                    case 1: return "penny";
                    case 5: return "nickel";
                    case 10: return "dime";
                    default: return "quarter";
                }
            }
            switch (coinType)
            {
                case 1: return "pennies";
                case 5: return "nickels";
                case 10: return "dimes";
                default: return "quarters";
            }
        }

        public static int GetNextLowestCoinType(int coinType)
        {
            switch (coinType)
            {
                case 25:
                    return 10;
                case 10:
                    return 5;
                case 5:
                    return 1;
                default:
                    return int.MinValue;
            }
        }

       private static int GetCollectionTotal(Dictionary<int, int> collection)
        {
            return collection.Aggregate(0, (current, pair) => current + (pair.Key * pair.Value));
        }

        private static void AddCoinToCollection(int coinToAdd, Dictionary<int, int> collection, int numberOfCoinsToAdd = 1)
        {
            if (!collection.ContainsKey(coinToAdd))
            {
                collection[coinToAdd] = numberOfCoinsToAdd;
            }
            else
            {
                collection[coinToAdd] += numberOfCoinsToAdd;
            }
        }

    }
}