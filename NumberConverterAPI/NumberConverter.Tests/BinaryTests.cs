using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterAPI.Service;

namespace NumberConverter.Tests
{
    [TestClass]
    public class BinaryTests
    {
        [TestMethod]
        [DataRow(0, "0")]
        [DataRow(1, "1")]
        [DataRow(2, "10")]
        [DataRow(5, "101")]
        [DataRow(10, "1010")]
        [DataRow(13, "1101")]
        [DataRow(24, "11000")]
        [DataRow(33, "100001")]
        [DataRow(46, "101110")]
        [DataRow(63, "111111")]
        [DataRow(64, "1000000")]
        [DataRow(97, "1100001")]
        [DataRow(100, "1100100")]
        [DataRow(324, "101000100")]
        [DataRow(599, "1001010111")]
        [DataRow(1784, "11011111000")]
        [DataRow(3000, "101110111000")]
        public void DecimalToBinaryHappyRoad(int num, string expectedResult)
        {
            Binary test = new Binary();
            string result = test.Convert(num);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, "0")]
        [DataRow(1, "1")]
        [DataRow(2, "10")]
        [DataRow(5, "101")]
        [DataRow(10, "1010")]
        [DataRow(13, "1101")]
        [DataRow(24, "11000")]
        [DataRow(33, "100001")]
        [DataRow(46, "101110")]
        [DataRow(63, "111111")]
        [DataRow(64, "1000000")]
        [DataRow(97, "1100001")]
        [DataRow(100, "1100100")]
        [DataRow(324, "101000100")]
        [DataRow(599, "1001010111")]
        [DataRow(1784, "11011111000")]
        [DataRow(3000, "101110111000")]
        public void BinaryToDecimalHappyRoad(int expectedResult, string binary)
        {
            Binary test = new Binary();
            int result = test.Convert(binary);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1, "")]
        [DataRow(2147483647, "1111111111111111111111111111111")]
        //[DataRow(2147483648, "")] cannot do this because int is not big enough
        public void DecimalToBinaryEdgeTest(int num, string expectedResult)
        {
            Binary test = new Binary();
            string result = test.Convert(num);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1, "")]
        [DataRow(-2, "100000000000000000000000000000000")]        
        public void BinaryToDecimalEdgeTest(int expectedResult, string binary)
        {
            Binary test = new Binary();
            int result = test.Convert(binary);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
