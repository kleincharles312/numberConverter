using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberConverterAPI.Models
{
    public class ReturnedNumbers
    {
        public int Base10 { get; set; }
        public string Binary { get; set; }
        public string Hex { get; set; }
        public string RomanNumeral { get; set; }
        //public string Words { get; set; }
        // TODO: Add in Words
    }
}
