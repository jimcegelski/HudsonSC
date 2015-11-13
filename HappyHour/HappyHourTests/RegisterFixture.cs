using System.Collections.Generic;
using HappyHour;
using NUnit.Framework;

namespace HappyHourTests
{
    [TestFixture]
    public class RegisterFixture
    {
        [Test]
        public void PrintReceiptShowsNameOfCustomer()
        {
            Order testOrder = new Order("Jim Cegelski");
            Register register = new Register(testOrder);
            List<string> receipt = register.PrintReceipt();

            Assert.AreEqual(receipt[0], "Customer: Jim Cegelski");
        }
    }
}
