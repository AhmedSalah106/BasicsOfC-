using BasicsOfC_.Enums;
using BasicsOfC_.inheritance;
using BasicsOfC_.inheritance.ImplicitAndExplicitInterfaceImplementation;
using BasicsOfC_.OperatorOverload;
using BasicsOfC_.Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-------------inheritance-------------------
            Car myCar = new Car();
            myCar.Move(); // Output: The car is moving. 

            Vehicle vehicle = new Car();
            vehicle.Move(); // Output: The vehicle is moving. because the Move method in the Car class is hiding the Move method in the Vehicle class, not overriding it. To achieve polymorphism, you would need to use the 'virtual' keyword in the base class and the 'override' keyword in the derived class.




            //-------------reference type-------------------

            Test1 test = new Test1();
            test.Value = 1;
            void ModifyTest(Test1 t)
            {
                t.Value = 2;
            }
            ModifyTest(test);
            Console.WriteLine(test.Value); // Output: 2, because Test1 is a reference type, and when we pass it to the ModifyTest method, we are passing a reference to the same object in memory. Therefore, any modifications made to the object within the ModifyTest method will affect the original object outside the method.

            void ModifyTestreference(Test1 test1)
            {
                test1 = new Test1();
                test1.Value = 3;
            }
            ModifyTestreference(test);
            Console.WriteLine(test.Value); // Output: 2, because in the ModifyTestreference method, we are creating a new instance of Test1 and assigning it to the test1 parameter. This does not affect the original test object outside the method, which still holds the reference to the original Test1 instance with Value set to 2.

            void modifyTestPassedReference(ref Test1 test1)
            {
                test1 = new Test1();
                test1.Value = 4;
            }
            modifyTestPassedReference(ref test);
            Console.WriteLine(test.Value); // Output: 4, because when we use the 'ref' keyword, we are passing a reference to the reference of the object. This means that any changes made to the test1 parameter within the modifyTestPassedReference method will affect the original test variable outside the method, allowing us to assign a new instance of Test1 and modify its Value property.





            //-------------Enums-------------------


            Weather weather = Weather.Snowy | Weather.Rainy;
            Console.WriteLine(weather); // Output: Snowy, Rainy, because the Weather enum is defined with the [Flags] attribute, which allows us to combine multiple enum values using bitwise operations. When we combine Weather.Snowy and Weather.Rainy using the bitwise OR operator (|), we get a new value that represents both conditions. When we print the weather variable, it will display the combined values as "Snowy, Rainy".










            //------------operator overloading-------------------
            Point point1 = new Point()
            { x = 1, y = 2 };
            Point point2 = new Point()
            { x = 1, y = 2 };

            Point point3 = point1 + point2;
            Console.WriteLine(point3);

            point3 = point1 - point2;
            Console.WriteLine(point3);

            point3 = point1 * point2;
            Console.WriteLine(point3);

            point3 = point1 / point2;
            Console.WriteLine(point3);

            point3++;
            Console.WriteLine(point3);

            point3--;
            Console.WriteLine(point3);




            //-----------------implicit and explicit interface implementation-------------------
            MainClass mainClass = new MainClass();
            mainClass.Method(); // Output: Method from MainClass, because we are calling the Method directly on the mainClass object, which will invoke the implementation defined in the MainClass.
            ((FirstInterface)mainClass).Method(); // Output: Method from FirstInterface, because we are explicitly casting the mainClass object to the FirstInterface type, which allows us to access the Method implementation defined in the FirstInterface.
            ((SecondInterface)mainClass).Method(); // Output: Method from SecondInterface, because we are explicitly casting the mainClass object to the SecondInterface type, which allows us to access the Method implementation defined in the SecondInterface.




        }
    }
}