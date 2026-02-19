using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.inheritance.ImplicitAndExplicitInterfaceImplementation
{
    public class MainClass : FirstInterface, SecondInterface
    {
        public void Method()
        {
            Console.WriteLine("This is the implementation of the Method from FirstInterface.");
        }

        void FirstInterface.Method()
        {
            Console.WriteLine("This is the explicit implementation of the Method from FirstInterface.");
        }

        void SecondInterface.Method()
        {
            Console.WriteLine("This is the explicit implementation of the Method from SecondInterface.");
        }
    }
}
