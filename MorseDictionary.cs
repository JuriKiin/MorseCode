using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MorseCodeTranslator
{
    class MorseDictionary
    {
        public Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>();

        public MorseDictionary()
        {
            morseCodeDictionary.Add('A',"o-");
            morseCodeDictionary.Add('B', "-ooo");
            morseCodeDictionary.Add('C', "-o-o");
            morseCodeDictionary.Add('D', "-oo");
            morseCodeDictionary.Add('E', "o");
            morseCodeDictionary.Add('F', "oo-o");
            morseCodeDictionary.Add('G', "--o");
            morseCodeDictionary.Add('H', "oooo");
            morseCodeDictionary.Add('I', "oo");
            morseCodeDictionary.Add('J', "o---");
            morseCodeDictionary.Add('K', "-o-");
            morseCodeDictionary.Add('L', "o-oo");
            morseCodeDictionary.Add('M', "--");
            morseCodeDictionary.Add('N', "-o");
            morseCodeDictionary.Add('O', "---");
            morseCodeDictionary.Add('P', "o--o");
            morseCodeDictionary.Add('Q', "--o-");
            morseCodeDictionary.Add('R', "o-o");
            morseCodeDictionary.Add('S', "ooo");
            morseCodeDictionary.Add('T', "-");
            morseCodeDictionary.Add('U', "oo-");
            morseCodeDictionary.Add('V', "ooo-");
            morseCodeDictionary.Add('W', "o--");
            morseCodeDictionary.Add('X', "-oo-");
            morseCodeDictionary.Add('Y', "-o--");
            morseCodeDictionary.Add('Z', "--oo");
            morseCodeDictionary.Add('1', "o----");
            morseCodeDictionary.Add('2', "oo---");
            morseCodeDictionary.Add('3', "ooo--");
            morseCodeDictionary.Add('4', "oooo-");
            morseCodeDictionary.Add('5', "ooooo");
            morseCodeDictionary.Add('6', "-oooo");
            morseCodeDictionary.Add('7', "--ooo");
            morseCodeDictionary.Add('8', "---oo");
            morseCodeDictionary.Add('9', "----o");
            morseCodeDictionary.Add('0', "-----");
            morseCodeDictionary.Add(' ',"*");

        }
        public char GetKey(string input)
        {
            char key = 'A';
            foreach(KeyValuePair<char,string> pair in morseCodeDictionary)
            {
                if(pair.Value == input)
                {
                    key = pair.Key;
                }
            }

            return key;
        }


    }
}
