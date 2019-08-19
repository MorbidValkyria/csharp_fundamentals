using System;
using System.Collections.Generic;
using System.IO;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game();
        }

        public static string GetWord()
        {
            string[] words = File.ReadAllLines(@"./words.txt");
            Random rand = new Random();
            int iWord = rand.Next(words.Length); 
            return $"{words[iWord]}".ToLower();
        }

        public static string GetChar()
        {
            Console.WriteLine("Enter a character:");
            string guess = Console.ReadLine();
            return guess;
        }
        public static void ShowWord(List<string> word)
        {
            for (int i = 0; i < word.Count; i++)
            {
                Console.Write($" {word[i]} ");
            }
            Console.WriteLine("");
        }

        public static bool CheckWord(string letter, string word, List<string> blanks)
        {
            bool result = false;
        
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == letter){
                    result = true;
                    blanks[i] = letter;
                }
            }
                
            return result;
        }
        public static void ShowStrikes(int numStrikes)
        {
            for (int i = 0; i < numStrikes; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine("");
        }

        public static void Game()
        {
            int strikes = 0;
            int maxStrikes = 3;
            bool play = true;
            string word = GetWord();
            List<string> blanks = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                blanks.Add("_");
            }
            while (play)
            {
                ShowWord(blanks);
                string letter = GetChar();

                bool foundChar = CheckWord(letter, word, blanks);

                if (!foundChar)
                {
                    strikes+=1;
                    ShowStrikes(strikes);
                }
                if (strikes >= maxStrikes)
                {
                    play = false;
                }

                if (!blanks.Contains("_"))
                {
                    play = false;
                }
            }
            if (strikes < maxStrikes)
            {
                System.Console.WriteLine("Winner!");
            }
            else
            {
                System.Console.WriteLine("You Loose!");
            }
        }
    }
}
