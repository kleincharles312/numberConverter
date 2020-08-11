using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverterAPI.Models
{
    interface IConvertable
    {
        int Convert(string number);
        string Convert(int number);
        string Print(string number);
    }
}
