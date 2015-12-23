using CountCoins;
using NUnit.Framework;

namespace Test
{
    public class Test
    {
        [Test]
        public void One()
        {
            var coinCollections = CoinCounter.GetCoinCollections(1);
            Assert.AreEqual(1, coinCollections.Count);
            Assert.IsTrue(coinCollections.Contains("A penny"));
        }

        [Test]
        public void Two()
        {
            var coinCollections = CoinCounter.GetCoinCollections(2);
            Assert.AreEqual(1, coinCollections.Count);
            Assert.IsTrue(coinCollections.Contains("2 pennies"));
        }

        [Test]
        public void Five()
        {
            var coinCollections = CoinCounter.GetCoinCollections(5);
            Assert.AreEqual(2, coinCollections.Count);
            Assert.IsTrue(coinCollections.Contains("5 pennies"));
            Assert.IsTrue(coinCollections.Contains("A nickel"));
        }

        [Test]
        public void Six()
        {
            var coinCollections = CoinCounter.GetCoinCollections(6);
            Assert.AreEqual(2, coinCollections.Count);
            Assert.IsTrue(coinCollections.Contains("6 pennies"));
            Assert.IsTrue(coinCollections.Contains("A penny and a nickel"));
        }

        [Test]
        public void Ten()
        {
            var coinCollections = CoinCounter.GetCoinCollections(10);
            Assert.AreEqual(4, coinCollections.Count);
            Assert.IsTrue(coinCollections.Contains("10 pennies"));
            Assert.IsTrue(coinCollections.Contains("2 nickels"));
            Assert.IsTrue(coinCollections.Contains("5 pennies and a nickel"));
            Assert.IsTrue(coinCollections.Contains("A dime"));
        }

        [Test]
        public void Fifteen()
        {
            var coinCollections = CoinCounter.GetCoinCollections(15);
            Assert.AreEqual(6, coinCollections.Count);
            Assert.IsTrue(coinCollections.Contains("15 pennies"));
            Assert.IsTrue(coinCollections.Contains("10 pennies and a nickel"));
            Assert.IsTrue(coinCollections.Contains("5 pennies and 2 nickels"));
            Assert.IsTrue(coinCollections.Contains("5 pennies and a dime"));
            Assert.IsTrue(coinCollections.Contains("3 nickels"));
            Assert.IsTrue(coinCollections.Contains("A nickel and a dime"));
        }

        [Test]
        public void Hundred()
        {
            var coinCollections = CoinCounter.GetCoinCollections(100);
            Assert.AreEqual(242, coinCollections.Count);
        }
    }
}
