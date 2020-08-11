using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterAPI.Models;

namespace NumberConverter.Tests
{
    [TestClass]
    public class NumberToWordsTests
    {
        [TestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(2, "two")]
        [DataRow(3, "three")]
        [DataRow(4, "four")]
        [DataRow(5, "five")]
        [DataRow(6, "six")]
        [DataRow(7, "seven")]
        [DataRow(8, "eight")]
        [DataRow(9, "nine")]
        public void SingleDigitReturnsCorrect(int number, string expectedResult)
        {
            NumberToWords test = new NumberToWords();
            string result = test.Convert(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, "ten")]
        [DataRow(13, "thirteen")]
        [DataRow(22, "twenty-two")]
        [DataRow(33, "thirty-three")]
        [DataRow(44, "forty-four")]
        [DataRow(51, "fifty-one")]
        [DataRow(62, "sixty-two")]
        [DataRow(73, "seventy-three")]
        [DataRow(89, "eighty-nine")]
        [DataRow(98, "ninety-eight")]
        [DataRow(30, "thirty")]
        public void TwoDigitsReturnsCorrect(int number, string expectedResult)
        {
            NumberToWords test = new NumberToWords();
            string result = test.Convert(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(100, "one hundred")]
        [DataRow(133, "one hundred and thirty-three")]
        [DataRow(222, "two hundred and twenty-two")]
        [DataRow(330, "three hundred and thirty")]
        [DataRow(404, "four hundred and four")]
        [DataRow(510, "five hundred and ten")]
        [DataRow(675, "six hundred and seventy-five")]
        [DataRow(700, "seven hundred")]
        [DataRow(899, "eight hundred and ninety-nine")]
        [DataRow(913, "nine hundred and thirteen")]
        public void ThreeDigitsReturnsCorrect(int number, string expectedResult)
        {
            NumberToWords test = new NumberToWords();
            string result = test.Convert(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(100000, "one hundred thousand")]
        [DataRow(1000, "one thousand")]
        [DataRow(2250, "two thousand two hundred and fifty")]
        [DataRow(23005, "twenty-three thousand and five")]
        [DataRow(404444, "four hundred and four thousand four hundred and forty-four")]
        public void ThousandsReturnsCorrect(int number, string expectedResult)
        {
            NumberToWords test = new NumberToWords();
            string result = test.Convert(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(1000000, "one million")]
        [DataRow(1000001, "one million and one")]
        [DataRow(1234567, "one million two hundred and thirty-four thousand five hundred and sixty-seven")]
        //[DataRow(5000000112, "five hundred billion one hundred and twelve")]
        public void LargeNumbersReturnCorrect(int number, string expectedResult)
        {
            NumberToWords test = new NumberToWords();
            string result = test.Convert(number);
            Assert.AreEqual(expectedResult, result);
        }
        
        //TODO: add edge cases
    }
}
