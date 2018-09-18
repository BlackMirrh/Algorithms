using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Misc;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private double epsilon = 1e-6;

        [TestMethod]
        //The Deposit and Withdraw methods will not accept negative numbers.
        public void AccountCannotHaveNegativeOverdraftLimit()
        {          
            Account account = new Account(-20);

            Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        }
        [TestMethod]
        // Account cannot overstep its overdraft limit.
        public void AccountOverdraftLimit()
        {
            Account account = new Account(200);

            Assert.AreEqual(205, account.OverdraftLimit);
        }

        [TestMethod]
        // The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
        public void AccountCorrectDepostAndWithdraw()
        {
            Account account = new Account(200);

            Assert.AreEqual(105, account.Deposit(105));
            Assert.AreEqual(110, account.Withdraw(110));
        }

        [TestMethod]
        // The Withdraw and Deposit methods return the correct results.
        public void AccountCorrectResultDepostAndWithdraw()
        {
            Account account = new Account(200);

            Assert.AreEqual(100, account.Deposit(100));
            Assert.AreEqual(100, account.Withdraw(100));
        }
    }
}
