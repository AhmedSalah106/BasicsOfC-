using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.Generic
{
    public class GenericClass<T>
    {
        public T Value { get; set; }
        public void DisplayValue()
        {
            Console.WriteLine($"The value is: {Value}");
        }
    }
}
