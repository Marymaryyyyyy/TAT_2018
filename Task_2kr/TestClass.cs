using NUnit.Framework;
using System;
using Task_2kr;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [TestCase("0,0002", "0,0003", 0.00000006)]
        [TestCase("1000", "1000", 1000000)]
        [TestCase("4", "9", 36)]
        [Test]
        public void ValidSquare(string width, string length, double expectedSquare)
        {
            string[] args = {width, length };
            Rectangle rectangle = new Rectangle(args);
            Assert.AreEqual(expectedSquare, rectangle.CalculateSquare());
        }
    }
}
