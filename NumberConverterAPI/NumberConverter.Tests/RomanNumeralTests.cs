using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterAPI.Models;

namespace NumberConverter.Tests
{
    [TestClass]
    public class RomanNumeralTests
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        public void Numbers1Thru3ReturnCorrectRN(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);            
        }

        [TestMethod]
        public void FourReturnsIV()
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(4);
            Assert.AreEqual("IV", mock);
        }

        [TestMethod]
        public void FiveReturnsV()
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(5);
            Assert.AreEqual("V", mock);
        }

        [TestMethod]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        public void Numbers6Thru8ReturnCorrectRN(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        public void NineReturnsIX()
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(9);
            Assert.AreEqual("IX", mock);
        }

        [TestMethod]
        public void TenReturnsX()
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(10);
            Assert.AreEqual("X", mock);
        }

        [TestMethod]
        [DataRow(11, "XI")]
        [DataRow(14, "XIV")]
        [DataRow(15, "XV")]
        [DataRow(16, "XVI")]
        [DataRow(19, "XIX")]
        public void Numbers11Thru19ReturnCorrectRN(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(40, "XL")]
        public void FortyReturnsXL(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(50, "L")]
        [DataRow(45, "XLV")]
        [DataRow(33, "XXXIII")]
        public void FiftyReturnsX(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(90, "XC")]
        public void NinetyReturnsXC(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(100, "C")]
        [DataRow(99, "XCIX")]
        [DataRow(84, "LXXXIV")]
        [DataRow(77, "LXXVII")]
        public void OneHundredyReturnsC(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(500, "D")]
        [DataRow(494, "CDXCIV")]
        public void FiveHundredReturnsD(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(400, "CD")]
        public void FourHundredReturnsCD(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(900, "CM")]
        public void NineHundredReturnsCM(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(1000, "M")]
        [DataRow(1998, "MCMXCVIII")]
        public void OneThousandReturnsCM(int stub, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow("C", 100)]
        [DataRow("L", 50)]
        [DataRow("XXXIII", 33)]
        [DataRow("XVII", 17)]
        public void No9or4RetunsCorrectNum(string stub, int expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            int mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow("IV", 4)]
        [DataRow("IX", 9)]
        [DataRow("XL", 40)]
        [DataRow("XLI", 41)]
        [DataRow("CM", 900)]
        [DataRow("XCIX", 99)]
        [DataRow("LIV", 54)]
        [DataRow("XLIV", 44)]
        public void Ninesor4RetunsCorrectNum(string stub, int expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            int mock = test.Convert(stub);
            Assert.AreEqual(expectedResult, mock);
        }

        [TestMethod]
        [DataRow(-1, "")]
        [DataRow(4000, "The number entered is too big")]
        public void IntToRomanNumeralEdgeTests(int num, string expectedResult)
        {
            RomanNumeral test = new RomanNumeral();
            string result = test.Convert(num);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
