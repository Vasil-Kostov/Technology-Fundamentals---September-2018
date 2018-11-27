﻿namespace _04._Morse_Code_Translator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {

        static void Main()
        {
            Dictionary<string, char> morseAlphabetDictionary = new Dictionary<string, char>()
                                   {
                                       { ".-"   ,'A'},
                                       { "-..." ,'B'},
                                       { "-.-." ,'C'},
                                       { "-.."  ,'D'},
                                       { "."    ,'E'},
                                       { "..-." ,'F'},
                                       { "--."  ,'G'},
                                       { "...." ,'H'},
                                       { ".."   ,'I'},
                                       { ".---" ,'J'},
                                       { "-.-"  ,'K'},
                                       { ".-.." ,'L'},
                                       { "--"   ,'M'},
                                       { "-."   ,'N'},
                                       { "---"  ,'O'},
                                       { ".--." ,'P'},
                                       { "--.-" ,'Q'},
                                       { ".-."  ,'R'},
                                       { "..."  ,'S'},
                                       { "-"    ,'T'},
                                       { "..-"  ,'U'},
                                       { "...-" ,'V'},
                                       { ".--"  ,'W'},
                                       { "-..-" ,'X'},
                                       { "-.--" ,'Y'},
                                       { "--.." ,'Z'},
                                       { "-----",'0'},
                                       { ".----",'1'},
                                       { "..---",'2'},
                                       { "...--",'3'},
                                       { "....-",'4'},
                                       { ".....",'5'},
                                       { "-....",'6'},
                                       { "--...",'7'},
                                       { "---..",'8'},
                                       { "----.",'9'}
                                   };

            List<string> morse = Console.ReadLine()
                                 .Split("|")
                                 .ToList();
            List<string> message = new List<string>();

            foreach (var word in morse)
            {
                StringBuilder sb = new StringBuilder();

                string[] letters = word.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var letter in letters)
                {
                    sb.Append(morseAlphabetDictionary[letter].ToString());
                }

                message.Add(sb.ToString());
            }

            Console.WriteLine(string.Join(" ", message));
            
        }
    }
}
