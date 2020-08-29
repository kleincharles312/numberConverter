using System;
using System.Collections.Generic;
using System.Text;


namespace NumberConverterAPI.Service
{
    /// <summary>
    /// Converts from int to binary or from binary to int
    /// </summary>
    public class Binary : Number
    {
        // this may be set up to use with an interface. What would be the application of that interface?

        /// <summary>
        /// Converts base10 to binary string
        /// </summary>
        /// <param name="number"> base10 number</param>
        /// <returns></returns>
        public override string Convert(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            string binary = "";
            //TODO: convertingNum is a little smelly, how can it be worked around?
            int convertingNum = number;
            while (convertingNum > 0)
            {
                binary = (convertingNum % 2).ToString() + binary;
                convertingNum /= 2;
            }
            
            return binary;
        }
        /// <summary>
        /// Converts binary string to base10
        /// </summary>
        /// <param name="binary">binary string</param>
        /// <returns>returns -1 if invalid and -2 if too big for int</returns>
        public override int Convert(string binary)
        {
            // this is if number is too big enough for int to hold
            if (binary.Length > 31)
            {
                return -2;
            }
            else if (binary == "")
            {
                return -1;
            }

            int value = 0;
            int placeValue = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                char place = binary[i];
                bool isValid = (place == '0') || (place == '1');
                if (isValid)
                {
                    value += (placeValue * (int.Parse(place.ToString())));
                }
                else
                {
                    return -1;
                }

                placeValue *= 2;
            }
            return value;
        }

        public override string Print(string number)
        {
            return $"Binary: {number}";
        }
    }
}
