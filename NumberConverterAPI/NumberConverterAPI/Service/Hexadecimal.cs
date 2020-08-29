using System;
using System.Collections.Generic;
using System.Text;


namespace NumberConverterAPI.Service
{
    public class Hexadecimal : Number
    {
        private static string[] hexDigits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        private static Dictionary<char, int> hexKeys = new Dictionary<char, int>()
        {
            {'0', 0 },
            {'1', 1},
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'A', 10},
            {'B', 11},
            {'C', 12},
            {'D', 13},
            {'E', 14},
            {'F', 15},
        };


        /// <summary>
        /// Converts int to hexadecimal string
        /// </summary>
        /// <param name="number">number to convert</param>
        /// <returns>hexidecimal string, empty string if invalid</returns>
        public override string Convert(int number)
        {

            if (number == 0)
            {
                return "0";
            }

            int convertingNumber = number;
            int remainderNumber = 0;
            string hexadecimal = "";
            while (convertingNumber > 0)
            {                
                remainderNumber = convertingNumber % 16;
                hexadecimal = hexDigits[remainderNumber] + hexadecimal;                
                convertingNumber /= 16;      
            }
            
            return hexadecimal;
        }

        /// <summary>
        /// Converts hexadecimal string to int
        /// </summary>
        /// <param name="hex">hexadecimal string</param>
        /// <returns>returns -1 if invalid and -2 if will not fit in int</returns>
        public override int Convert(string hex)
        {
            // a hex string may be too big to fit in an integer
            hex = hex.ToUpper();
            bool isTooBigForInt = (hex.Length == 8 && hex.Substring(0, 1) == "8") || hex.Length > 8;
            if (isTooBigForInt)
            {
                return -2;
            }
            else if (hex == "")
            {
                return -1;
            }

            int value = 0;
            int placeValue = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                if (hexKeys.ContainsKey(hex[i]))
                {
                    value += (hexKeys[hex[i]] * placeValue);
                }
                else
                {
                    return -1;
                }

                placeValue *= 16;
            }

            return value;
        }

        public override string Print(string number)
        {
            return $"Hexadecimal: {number}";
        }
    }
}
