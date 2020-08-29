using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumberConverterAPI.Models;

namespace NumberConverterAPI.Service
{
    public class ConverterHub
    {
        private string numberToConvert;
        private string originalType;
        private Binary binary = new Binary();
        private Hexadecimal hex = new Hexadecimal();
        private RomanNumeral roman = new RomanNumeral();
        private NumberToWords words = new NumberToWords();
        // TODO: Implement Words to Numbers

        public ConverterHub(string number, string type)
        {
            numberToConvert = number;
            originalType = type;
        }

        public ReturnedNumbers PerformConversion()
        {
            ReturnedNumbers result = new ReturnedNumbers();
            int baseTen;
            // TODO: Loop through dictionary and perform conversions then add conversion as ReturnedNumbers
            if (originalType == "i")
            {
                int.TryParse(numberToConvert, out int num);
                baseTen = num;
            }
            else if (originalType == "b")
            {                
                baseTen = binary.Convert(numberToConvert);
            }
            else if (originalType == "h")
            {
                baseTen = hex.Convert(numberToConvert);
            }
            else if (originalType == "rn")
            {
                baseTen = roman.Convert(numberToConvert);
            }
            else if (originalType == "w")
            {
                return null;
                // TODO: Add numbers to words
            }
            else
            {
                // This is needed for error handling
                return null;
            }

            result.Base10 = baseTen;
            result.Binary = binary.Convert(baseTen);
            result.Hex = hex.Convert(baseTen);
            result.RomanNumeral = roman.Convert(baseTen);
            //result.Words = words.Convert(baseTen);

            return result;
        }
    }
}
