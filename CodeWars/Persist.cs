using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            // Write a function, `persistence`, that takes in a positive parameter `num` and returns its multiplicative persistence, which is the number of times you must multiply the digits in `num` until you reach a single digit.
            long result = 1;
            
            if (Digits(n).Count > 1)
            {
                foreach (int i in Digits(n))
                {
                    result *= i;
                }
            }
            else
            {
                return 0;
            }

            return Persistence(result) + 1;
        }

        static List<int> Digits(long num)
        {
            List<int> nums = new List<int>();
            foreach (char i in (num.ToString()))
            {
                nums.Add(int.Parse(i.ToString()));
            }

            return nums;
        }
    }
}
