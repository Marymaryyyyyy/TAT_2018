using System;
using System.Linq;
using Xunit;
using Task_Dev2;


namespace xUnitTestTask_Dev2
{
    public class BuilderTest1
    {
        [Fact]
        public void EmptyLineTest()
        {
            Builder build = new Builder(string.Empty);
            Assert.Equal(string.Empty, build.FindSequenceOfEvenIndex());
        } 

        [Theory]
        [InlineData("1","1")]
        [InlineData("1234","13")]
        [InlineData("12345","135")]
        public void CurrentSymbolsTest(string line, string result)
        {
            Builder build = new Builder(line);
            Assert.Equal(result, build.FindSequenceOfEvenIndex());
        }
    }
}
