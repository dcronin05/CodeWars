using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class BitCounting
    {
        // TODO: Write a function that takes an (unsigned) integer as input, and returns the number of bits that are equal to one in the binary representation of that number.
        /*   Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case public static int CountBits(int n) => 0; */

        public static int CountBits(int n)
        {
            var result = 0;
            var bitVar = Convert.ToString(n, 2);
            foreach (char i in bitVar) if (i == '1') result++;
            return result;
        }
    }
}
