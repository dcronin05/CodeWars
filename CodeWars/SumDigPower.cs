using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SumDigPower
    {

        public static long[] SumDigPow(long a, long b)
        {
            /* The number 89 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. What's the use of saying "Eureka"? Because this sum gives the same number.

            In effect: 89 = 8^1 + 9^2

            The next number in having this property is 135.

            See this property again: 135 = 1^1 + 3^2 + 5^3

            We need a function to collect these numbers, that may receive two integers a, b that defines the range [a, b] (inclusive) and outputs a list of the sorted numbers in the range that fulfills the property described above. 
            */

            Dictionary<long, long> values = new Dictionary<long, long>();
            List<long> result = new List<long>();

            for (long i = a; i <= b; i++)
            {
                values.Add(i, i);
            }

            for (long i = a; i <= b; i++)
            {
                long sum = 0;
                int powerCount = 1;
                foreach (long num in Digits(values[i]))
                {
                    sum += (long) Math.Pow (num, powerCount);
                    powerCount++;
                }

                if (sum == values[i]) result.Add(sum);
            }

            return result.ToArray();
        }

        static List<long> Digits(long num)
        {
            List<long> nums = new List<long>();
            foreach (char i in (num.ToString()))
            {
                nums.Add(long.Parse(i.ToString()));
            }

            return nums;
        }

        static List<long> NumberRange(long a, long b)
        { 
            return new List<long>();
        }
    }
}
