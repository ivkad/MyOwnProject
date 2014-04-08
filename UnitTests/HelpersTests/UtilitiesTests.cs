using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpersLibrary.Components;
using NUnit;
using NUnit.Framework;

namespace UnitTests.HelpersTests
{
    [TestFixture]
    class UtilitiesTests
    {
        [Test]
        public void DoSomethingTest()
        {
            Utilities util = new Utilities();
            Assert.IsTrue(util.DoSomething());
        }

        [Test]
        [TestCase]
        public void GetPricesTest()
        {
            Utilities util = new Utilities(new Helper());
            var prices = util.GetPrices();
            Assert.AreEqual(prices.Count(), 2);
        }

        [TestCase(12,4)]
        [TestCase(15, 5)]
        [TestCase(21, 7)]
        public void TestCaseTest(int a, int b)
        {
            Assert.AreEqual(a, 3*b);
        }

    }
}
