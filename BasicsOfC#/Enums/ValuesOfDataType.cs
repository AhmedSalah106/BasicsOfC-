using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.Enums
{
    public enum ValuesOfDataType : long // i can use any integral type (byte, sbyte, short, ushort, int, uint, long, ulong) as the underlying type for an enum. By default, the underlying type of an enum is int, but you can specify a different integral type if needed. In this case, we are using long as the underlying type for the ValuesOfDataType enum.
    {
        MinValue = long.MinValue,
        MaxValue = long.MaxValue
    }
}
