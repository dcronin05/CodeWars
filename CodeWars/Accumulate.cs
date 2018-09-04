using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Accumulate
    {

        public static string Accum(string s)
        {
            Dictionary<int, string> digits = new Dictionary<int, string>();

            for (int i = 1; i <= s.Length; i++)
            {
                digits.Add(i, s[i-1].ToString().ToUpper());
                if (i > 1)
                {
                    for (int multi = 1; multi < i; multi++)
                    {
                        digits[i] = digits[i] + s[i - 1].ToString().ToLower();
                    }

                }
            }

            string result = "";
            foreach (int i in digits.Keys) result += digits[i] + "-";

            return result.Remove(result.Length - 1);
        }
    }
}
