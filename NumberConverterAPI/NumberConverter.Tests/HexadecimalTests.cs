using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterAPI.Service;

namespace NumberConverter.Tests
{
    [TestClass]
    public class HexadecimalTests
    {
        [TestMethod]
        [DataRow(0, "0")]
        [DataRow(1, "1")]
        [DataRow(10, "A")]
        [DataRow(11, "B")]
        [DataRow(12, "C")]
        [DataRow(13, "D")]
        [DataRow(14, "E")]
        [DataRow(15, "F")]
        [DataRow(16, "10")]
        [DataRow(20, "14")]
        [DataRow(31, "1F")]
        [DataRow(42, "2A")]
        [DataRow(53, "35")]
        [DataRow(64, "40")]
        [DataRow(75, "4B")]
        [DataRow(86, "56")]
        [DataRow(97, "61")]
        [DataRow(108, "6C")]
        [DataRow(129, "81")]
        [DataRow(159, "9F")]
        [DataRow(160, "A0")]
        [DataRow(255, "FF")]
        [DataRow(256, "100")]
        [DataRow(510, "1FE")]
        [DataRow(1250, "4E2")]
        [DataRow(6459, "193B")]
        [DataRow(89146, "15C3A")]
        [DataRow(1234567, "12D687")]
        [DataRow(12345678, "BC614E")]
        [DataRow(2147483647, "7FFFFFFF")]
        public void Base10ToHexHappyPathTest(int number, string expectedResult)
        {
            Hexadecimal test = new Hexadecimal();
            string result = test.Convert(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, "0")]
        [DataRow(1, "1")]
        [DataRow(10, "A")]
        [DataRow(11, "B")]
        [DataRow(12, "C")]
        [DataRow(13, "D")]
        [DataRow(14, "E")]
        [DataRow(15, "F")]
        [DataRow(16, "10")]
        [DataRow(20, "14")]
        [DataRow(31, "1F")]
        [DataRow(42, "2A")]
        [DataRow(53, "35")]
        [DataRow(64, "40")]
        [DataRow(75, "4B")]
        [DataRow(86, "56")]
        [DataRow(97, "61")]
        [DataRow(108, "6C")]
        [DataRow(129, "81")]
        [DataRow(159, "9F")]
        [DataRow(160, "A0")]
        [DataRow(255, "FF")]
        [DataRow(256, "100")]
        [DataRow(510, "1FE")]
        [DataRow(1250, "4E2")]
        [DataRow(6459, "193B")]
        [DataRow(89146, "15C3A")]
        [DataRow(1234567, "12D687")]
        [DataRow(12345678, "BC614E")]
        [DataRow(2147483647, "7FFFFFFF")]
        public void HexToBase10HappyPathTest(int expectedResult, string hex)
        {
            Hexadecimal test = new Hexadecimal();
            int result = test.Convert(hex);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1, "")]        
        public void Base10ToHexEdgeTest(int num, string expectedResult)
        {
            Hexadecimal test = new Hexadecimal();
            string result = test.Convert(num);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1, "")]
        [DataRow(-1, "XYZ")]
        [DataRow(15, "f")]
        [DataRow(510, "1fe")]
        public void HexToBase10EdgeTest(int expectedResult, string hex)
        {
            Hexadecimal test = new Hexadecimal();
            int result = test.Convert(hex);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
