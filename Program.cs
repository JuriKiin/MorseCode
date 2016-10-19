using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MorseCodeTranslator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MorseDictionary morDict = new MorseDictionary();
            string userInput = "";
            string morseString = "";

            Console.WriteLine("X--------------------------------------------X");
            Console.WriteLine("Welcome to the MorseCode - English Translator!");
            Console.WriteLine("Author: Juri Kiin");
            Console.WriteLine("Created: October 7 2016");
            Console.WriteLine();
            Console.WriteLine("Simply type in either morse code or english.");
            Console.WriteLine("When typing in morse code, seperate letters by a space");
            Console.WriteLine("And seperate words by *");
            Console.WriteLine("X--------------------------------------------X");


            while(true)
            {
                morseString = "";   //Reset the morse string every time.
                Console.Write("English or Morse Code (Type E / M): ");
                userInput = Console.ReadLine();
                string userString = userInput.ToUpper();

                if (userString == "E")
                {
                    Console.Write("Type in English: ");

                    string english = "";
                    english = Console.ReadLine();

                    string englishInput = english.ToUpper();

                    //We are using a English
                    foreach (char c in englishInput)
                    {
                        if (morDict.morseCodeDictionary.ContainsKey(c))
                        {
                            morseString += morDict.morseCodeDictionary[c] + " ";
                        }
                        else
                        {
                            morseString += c;
                        }

                    }

                    Console.WriteLine(morseString);
                }
                else if(userString == "M")
                {
                    Console.Write("Type in Morse Code: ");

                    string morse = Console.ReadLine();
                    //We are using Morse Code
                    string[] splits = morse.Split(' ');

                    foreach (string s in splits)
                    {
                        if (morDict.morseCodeDictionary.ContainsValue(s))
                        {
                            morseString += morDict.GetKey(s);
                        }
                        else
                        {
                            morseString += s;
                        }
                    }

                    Console.WriteLine(morseString);
                }
                else
                {
                    Console.WriteLine("Unrecognized input. Please type either E or M.");
                    continue;
                }
            }
        }
    }
}
