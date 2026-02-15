using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_.OperatorOverload
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }


        public static Point operator +(Point p1, Point p2)
        {
            return new Point ()
            {
                x = p1.x + p2.x,
                y = p1.y + p2.y
            };
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point()
            {
                x = p1.x - p2.x,
                y = p1.y - p2.y
            };
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point()
            {
                x = p1.x * p2.x,
                y = p1.y * p2.y
            };
        }

        public static Point operator /(Point p1, Point p2)
        {
            return new Point()
            {
                x = p1.x / p2.x,
                y = p1.y / p2.y
            };
        }

        public static Point operator ++(Point p)
        {
            return new Point()
            {
                x = p.x + 1,
                y = p.y + 1
            };
        }

        public static Point operator --(Point p)
        {
            return new Point()
            {
                x = p.x - 1,
                y = p.y - 1
            };
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
        // Note: When you overload the == operator, you should also overload the != operator to maintain consistency. The implementation of the != operator should return the opposite of the == operator.
        public static bool operator !=(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }




        public override string ToString()
        {
            return $"{x} {y}"; 
        }
    }
}
