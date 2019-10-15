using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prob1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);
            Assert.IsNotNull(acc);
            Assert.IsNotInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.balance());
        }
    }
}
