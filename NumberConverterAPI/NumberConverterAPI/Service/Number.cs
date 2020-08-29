using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberConverterAPI.Service
{
    abstract public class Number
    {
        public abstract int Convert(string num);
        public abstract string Convert(int num);
        public abstract string Print(string num);

    }
}
