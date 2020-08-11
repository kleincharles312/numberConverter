using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterAPI.Service;
using NumberConverterAPI.Models;

namespace NumberConverter.Tests
{
    [TestClass]
    public class ConverterHubTests
    {
        [TestMethod]
        [DataRow("15", "i", 15, "1111", "F", "XV")]
        [DataRow("1111", "b", 15, "1111", "F", "XV")]
        [DataRow("F", "h", 15, "1111", "F", "XV")]
        [DataRow("XV", "rn", 15, "1111", "F", "XV")]
        public void CheckEachType(string numToConvert, string type, int expBase10, string expBinary, string expHex, string expRoman)
        {
            ConverterHub hub = new ConverterHub(numToConvert, type);
            ReturnedNumbers result = hub.PerformConversion();
            Assert.AreEqual(expBase10, result.Base10);
            Assert.AreEqual(expBinary, result.Binary);
            Assert.AreEqual(expHex, result.Hex);
            Assert.AreEqual(expRoman, result.RomanNumeral);
        }

    }
}
