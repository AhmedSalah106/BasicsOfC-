using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.Enums
{
    [Flags] // This attribute indicates that the enum can be treated as a bit field, allowing for bitwise operations to combine values.
    public enum Weather
    {
        Sunny = 1,
        Cloudy = 2,
        Rainy = 4,
        Snowy = 8

        //give every value a power of 2, so that we can combine them using bitwise operations to represent multiple weather conditions at once. For example, if we want to represent a day that is both sunny and rainy, we can use the value 5 (1 for sunny + 4 for rainy).
        /*
         *  4 => 0100
         *  1 => 0001
         *  4 | 1 => 0100 | 0001 => 0101 => 5 (new value)
         */
    }
}
