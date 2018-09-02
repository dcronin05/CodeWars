using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class IsThisATriangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            // TODO: Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of the given length and false in any other case.
            // All triangles must have a surface greater than 0 to be accepted.

            int sideLength1 = a + b; int sideLength2 = a + c; int sideLength3 = b + c;

            if (sideLength1 > c && sideLength2 > b && sideLength3 > a) return true; else return false;
        }
    }
}
