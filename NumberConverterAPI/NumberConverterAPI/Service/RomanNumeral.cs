using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverterAPI.Service
{
    public class RomanNumeral : Number
    {
        private int[] romanNumeralKeys { get; }
        private Dictionary<int, string> romanNumerals { get; }
        private Dictionary<char, int> numbers { get; }
        private Dictionary<string, int> roman4and9 { get; }

        public RomanNumeral()
        {
            romanNumeralKeys = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            romanNumerals = new Dictionary<int, string>()
        {
            {1000, "M" },
            {900, "CM" },
            {500, "D" },
            {400, "CD" },
            {100, "C" },
            {90, "XC" },
            {50, "L" },
            {40, "XL" },
            {10, "X" },
            {9, "IX" },
            {5, "V" },
            {4, "IV" },
            {1, "I" },
        };

            numbers = new Dictionary<char, int>()
        {
            {'M', 1000 },
            {'D', 500 },
            {'C', 100 },
            {'L', 50 },
            {'X', 10 },
            {'V', 5 },
            {'I', 1 },
        };

            roman4and9 = new Dictionary<string, int>()
            {
                {"CM", 900 },
                {"CD", 400 },
                {"XC", 90 },
                {"XL", 40 },
                {"IX", 9 },
                {"IV", 4 },
            };
        }


        /// <summary>
        /// Converts int to roman numeral string
        /// </summary>
        /// <param name="num">number to convert</param>
        /// <returns>returns The number entered is too big if negative or above 3000</returns>
        public override string Convert(int num)
        {
            //TODO: How high can these roman numerals actually go?
            if (num > 3999)
            {
                return "The number entered is too big";
            }
            if (num < 0)
            {
                return "";
            }

            int convertingNum = num;
            string result = "";
            
            for (int i = 0; i < romanNumeralKeys.Length; i++)
            {
                int key = romanNumeralKeys[i];
                if (convertingNum >= key)
                {
                    result += romanNumerals[key];
                    convertingNum -= key;
                    i--;
                }
            }
            
            return result;
        }

        //Convert digit = reverse the dictionary and read right to left
        /// <summary>
        /// Converts roman numeral string to int
        /// </summary>
        /// <param name="romanNumeral">string to convert</param>
        /// <returns>returns -1 if invalid</returns>
        public override int Convert(string romanNumeral)
        {            
            string parsing = romanNumeral.ToUpper(); 
            int result = 0;           

            for (int i = parsing.Length - 1; i >= 0; i--)
            {
                bool isValidChar = numbers.ContainsKey(parsing[i]);
                if (!isValidChar)
                {
                    return -1;
                }

                bool is4or9 = false;
                string fourOr9 = "";
                if (i >= 1)
                {
                    fourOr9 = parsing[i - 1].ToString() + parsing[i].ToString();
                    is4or9 = roman4and9.ContainsKey(fourOr9);                    
                }
                
                if (is4or9)
                {
                    result += roman4and9[fourOr9];
                    i--;
                }
                else
                {
                    char current = parsing[i];
                    result += numbers[current];
                } 
            }
            return result;
        }

        public override string Print(string number)
        {
            return $"Roman Numeral: {number}";
        }
    }
}
