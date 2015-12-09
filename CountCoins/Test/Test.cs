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
            Assert.AreEqual("A penny",coinCollections[0] );
        }

        [Test]
        public void Two()
        {
            var coinCollections = CoinCounter.GetCoinCollections(2);
            Assert.AreEqual(1, coinCollections.Count);
            Assert.AreEqual("2 pennies", coinCollections[0]);
        }

        [Test]
        public void Five()
        {
            var coinCollections = CoinCounter.GetCoinCollections(5);
            Assert.AreEqual(2, coinCollections.Count);
            Assert.AreEqual("A nickel", coinCollections[0]);
            Assert.AreEqual("5 pennies", coinCollections[1]);
        }

        [Test]
        public void Six()
        {
            var coinCollections = CoinCounter.GetCoinCollections(6);
            Assert.AreEqual(2, coinCollections.Count);
            Assert.AreEqual("A nickel and a penny", coinCollections[0]);
            Assert.AreEqual("6 pennies", coinCollections[1]);
        }

        [Test]
        public void Ten()
        {
            var coinCollections = CoinCounter.GetCoinCollections(10);
            Assert.AreEqual(4, coinCollections.Count);
            Assert.AreEqual("A dime", coinCollections[0]);
            Assert.AreEqual("2 nickles", coinCollections[1]);
            Assert.AreEqual("A nickel and 5 pennies", coinCollections[2]);
            Assert.AreEqual("10 pennies", coinCollections[3]);
        }
    }
}
