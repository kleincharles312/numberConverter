using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverterAPI.Service
{
    public class NumberToWords : Number
    {
        
        static private Dictionary<int, string> bigValues = new Dictionary<int, string>()
        {
            {0, "" },
            {1, "thousand " },
            {2, "million " },
            {3, "billion " },
            {4, "trillion " },
            {5, "quadrillion " },
            {6, "quintillion " },
            {7, "sextillion " },
            {8, "septillion " },
            {9,  "octillion "},
            {10, "nonillion " },
            {11, "decillion " }
        };

        static private Dictionary<char, string> onesValues = new Dictionary<char, string>()
        {
            {'0', "" },
            {'1', "one " },
            {'2', "two " },
            {'3', "three " },
            {'4', "four " },
            {'5', "five " },
            {'6', "six " },
            {'7', "seven " },
            {'8', "eight " },
            {'9', "nine " }
        };

        static private Dictionary<string, string> teenValues = new Dictionary<string, string>()
        {
            {"10", "ten" },
            {"11", "eleven " },
            {"12", "twelve " },
            {"13", "thirteen " },
            {"14", "fourteen " },
            {"15", "fifteen " },
            {"16", "sixteen " },
            {"17", "seventeen " },
            {"18", "eighteen " },
            {"19", "nineteen " }
        };

        static private Dictionary<char, string> tensValues = new Dictionary<char, string>()
        {
            {'0', "and " },
            {'2', "twenty" },
            {'3', "thirty" },
            {'4', "forty" },
            {'5', "fifty" },
            {'6', "sixty" },
            {'7', "seventy" },
            {'8', "eighty" },
            {'9', "ninety" }
        };


        /*
         * bigValues corresponds to a reverse counter when looping through the number
         * the other dictionaries line up as expected
         * 
         * How do I select teen numbers?
         * How do I know where to put "and"?
         * 
         * Should I use helper methods?
         */

        public override int Convert(string number)
        {
            throw new NotImplementedException();
        }

        public override string Convert(int number)
        {
            if (number == 0)
            {
                return "zero";
            }

            string result = "";
            string convertingNumber = number.ToString();

            // r is a reverse index used with bigVaules Dictionary
            int r = convertingNumber.Length - 1;
            for (int i = 0; i < convertingNumber.Length; i++)
            {
                char c = convertingNumber[i];                
                /*
                 *r->9 876 543 210
                 *   8,888,888,888
                 *b->0 210 210 210
                 *bk-3 222 111 000 
                 */
                int b = r % 3;
                int bigKey = r / 3;                
                
                if (!onesValues.ContainsKey(c))
                {
                    return "Not a Number";
                }

                // tens values
                if (b == 2)
                {
                    if (c == '0')
                    {
                        result += "";
                    }
                    else
                    {
                        result += onesValues[c] + "hundred ";
                    }
                    
                    if (convertingNumber[i + 1] == '0' && convertingNumber[i + 2] == '0')
                    {
                        if (bigKey < 1)
                        {
                            result += "";
                        }
                        else
                        {
                            if (c == '0')
                            {
                                result += "";
                            }
                            else
                            {
                                result += bigValues[bigKey];
                            }
                        }
                        i += 2;
                        r -= 2;
                    }
                    else
                    {
                        result += "and ";
                    }
                }
                else if (b == 1)
                {
                    if (c == '1')
                    {
                        string teen = c.ToString() + convertingNumber[i + 1];
                        result += teenValues[teen];
                        i++;
                        r--;
                    }
                    else if (c == '0')
                    {
                        result += onesValues[c];
                    }
                    else
                    {
                        if (convertingNumber[i + 1] == '0')
                        {
                            result += tensValues[c] + " ";
                            i++;
                            r--;
                        }                        
                        else
                        {
                            result += tensValues[c] + "-";
                        }
                        
                    }
                }
                else if (b == 0)
                {
                    if (c == '0')
                    {
                        result += "";
                    }
                    else
                    {
                        result += onesValues[c] + bigValues[bigKey];
                    }
                }

                r--;
            }            

            return result.Trim();
        }

        public override string Print(string number)
        {
            return $"Words: {number}";
        }

    }
}
