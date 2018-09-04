using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class MorseCodeDecoder
    {

        public static string Decode(string morseCode)
        {
            string[] morseInput = morseCode.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> newInput = new List<string>();
            newInput.Remove("");
            newInput.rem

            foreach (string s in morseInput) if (s.Length > 0) newInput.Add(s);

            string morseString = ".- / -... / -.-. / -.. / . / ..-. / --. / .... / .. / .--- / -.- / .-.. / -- / -. / --- / .--. / --.- / .-. / ... / - / ..- / ...- / .-- / -..- / -.-- / --.. / .---- / ..--- / ...-- / ....- / ..... / -.... / --... / ---.. / ----.";
            string[] morseSplit = morseString.Split(new string[] { " / " }, StringSplitOptions.None);
            Dictionary<string, char> morseDict = new Dictionary<string, char>
            {
                ["  "] = ' '
            };
            string characters = "abcdefghijklmnopqrstuvwxyz123456789";

            int counter = 0;
            foreach (string c in morseSplit)
            {
                morseDict[c] = characters[counter];
                counter++;
            }

            //List<string> result = new List<string>();
            string result = "";

            foreach (string s in morseInput)
            {
                if (s == "") continue;
                result += morseDict[s];
            }
             
            return result;
        }
    }
}
