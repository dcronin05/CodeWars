using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountingDuplicates.DuplicateCount("Indivisibility."));

            Console.Write("Persist: ");
            Persist.Persistence(358);
            Console.Read();
        }

        public static string TempMethod()
        {
            return "Hello world";
        }
    }
}
