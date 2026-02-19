using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.Comparison
{
    public class GroupNumbers : IComparable
    {
        public int[] numbers;
        public GroupNumbers(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int CompareTo(object obj)
        {
            if(obj == null) return 1; // If the other object is null, this instance is considered greater.
            GroupNumbers group = obj as GroupNumbers;

            if(group == null)
            {
                throw new ArgumentException("Object is not a GroupNumbers");
            }


            int thisSum = this.numbers.Sum();
            int otherSum = group.numbers.Sum();
            return thisSum.CompareTo(otherSum); // This will return -1, 0, or 1 based on the comparison of sums.


        }

        public override string ToString()
        {
            return $"GroupNumbers: [{string.Join(", ", numbers)}], Sum: {numbers.Sum()}";
        }
    }
}
