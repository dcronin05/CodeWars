using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            //TODO: Post this cove to solve Kada.
            var duplicates = new List<char>();
            var characters = new List<char>();

            foreach (var character in str.ToLower())
            {
                if (!characters.Contains(character))
                {
                    characters.Add(character);
                }
                else if (!duplicates.Contains(character))
                {
                    duplicates.Add(character);
                }
            }
            return duplicates.Count;
        }
    }
}
