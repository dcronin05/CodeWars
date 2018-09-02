using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ComplementaryDNA
    {
        public static string MakeComplement(string dna)
        {
            List<char> result = new List<char>();

            for (int i = 0; i < dna.Length; i += 1)
            {
                switch (dna.ToLower()[i])
                {
                    case 'a':
                        result.Add('T');
                        break;
                    case 't':
                        result.Add('A');
                        break;
                    case 'c':
                        result.Add('G');
                        break;
                    case 'g':
                        result.Add('C');
                        break;
                }

                //if (i == 't')
                //{
                //    result.Add('A');
                //} else if (i == 'a')
                //{
                //    result.Add('T');
                //} else if (i == 'c')
                //{
                //    result.Add('G');
                //} else if (i == 'g')
                //{
                //    result.Add('C');
                //}
            }

            return string.Join("", result);
        }
    }
}
