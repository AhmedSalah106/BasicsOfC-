using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.ObjectClass
{
    public class User 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // any class inherit from object class by default, so we can override some methods that help us.


        // this method is used to compare two objects of the same class, and it returns true if they are equal, otherwise it returns false. 
        public override bool Equals(object obj)
        {
            if(obj is User user)
            {
                return this.Name == user.Name && this.Age == user.Age;
            }
            return false;
        }
        

        public override string ToString()
        {
            return $"User: Name = {Name}, Age = {Age}";
        }
    }
}
