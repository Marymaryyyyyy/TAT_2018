using NUnit.Framework;
using System;
using System.Text;
using System.Threading.Tasks;
using Task_dev_3;

namespace nUnitTask_Dev3.Tests1
{
    [TestFixture]
    public class TestConverter
    {
        [TestCase(16, 28, "1C")]
        [TestCase(2, 8, "1000")]
        [TestCase(15, 15, "10")]
        [TestCase(10, 0, "0")]
        [Test]
        public void ValidBaseValidValueTest(int convertedToValue, int inputNumber, string result)
        {
            Converter converter = new Converter();
            Assert.AreEqual(result, converter.ConvertTo(inputNumber, convertedToValue));
        }
    }
}
