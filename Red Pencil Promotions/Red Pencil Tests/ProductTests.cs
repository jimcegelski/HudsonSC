using Microsoft.VisualStudio.TestTools.UnitTesting;
using Red_Pencil_Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Pencil_Tests
{
    [TestClass]
    public class ProductShould
    {
        [TestMethod]
        public void  ReturnsRedPencilTrueWhenChangeIsOver5PercentAnd30DaysOld()
        {
            var product = new Product();
            product.SetPrice(10, DateTime.Now.AddDays(-70));
            product.SetPrice(8, DateTime.Now.AddDays(-10));

            Assert.IsTrue(product.IsRedPencil);
        }

        [TestMethod]
        public void ReturnsRedPencilFalseWhenChangeLessThan30DaysOld()
        {
            var product = new Product();
            product.SetPrice(10, DateTime.Now.AddDays(-29));
            product.SetPrice(8, DateTime.Now);

            Assert.IsFalse(product.IsRedPencil);
        }

        [TestMethod]
        public void ReturnsRedPencilFalsePriceChangeIsLessThan3Percent()
        {
            var product = new Product();
            product.SetPrice(100, DateTime.Now.AddDays(-10));
            product.SetPrice(98, DateTime.Now);

            Assert.IsFalse(product.IsRedPencil);
        }

        [TestMethod]
        public void ReturnsRedPencilFalsePriceChangeIsGreaterThan30Percent()
        {
            var product = new Product();
            product.SetPrice(100, DateTime.Now.AddDays(-10));
            product.SetPrice(69, DateTime.Now);

            Assert.IsFalse(product.IsRedPencil);
        }

        [TestMethod]
        public void ReturnsRedPencilFalseAfter30DaysOfRedPencilPromotion()
        {
            var product = new Product();
            product.SetPrice(10, DateTime.Now.AddDays(-80));
            product.SetPrice(8, DateTime.Now.AddDays(-31));

            Assert.IsFalse(product.IsRedPencil);
        }
    }
}
