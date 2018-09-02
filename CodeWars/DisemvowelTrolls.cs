using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            // TODO: Re-submit code to kata.
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', };
            string aNewString = "";
            // TODO: Figure out source of error in kata compiler.
            foreach (char i in str) if (vowels.Contains(i)) { continue; } else aNewString += i.ToString();

            return aNewString;
        }
    }
}