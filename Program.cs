using System;
using System.IO;

namespace lab_4
{
    class Program
    {
        public static string path;

        static void Main(string[] args)
        {
            Console.WriteLine("String Values");
            Console.WriteLine();

            Console.Write("Enter the path of your file containing strings: ");
            path = @"" + Console.ReadLine();

            if (File.Exists(path))
            {
                Console.Clear();
                Console.WriteLine("File Exists.");
                Console.WriteLine("Your file contains: \n" + File.ReadAllText(path));

                int words = File.ReadAllText(path).Split().Length;
                Console.WriteLine("Amount of Words: " + words);

                VowelCounter(path);
                Value.StringValue(path);
            }
            else
            {
                Console.WriteLine("Invalid file path.");
            }
        }
        public static void VowelCounter(string userpath)
        {
            int vowelcount = 0;

            for (int i = 0; i < File.ReadAllText(userpath).Length; i++) // keeps going until it reaches end of string
            {
                if (userpath[i] == 'a' || userpath[i] == 'A'
                || userpath[i] == 'e' || userpath[i] == 'E'
                || userpath[i] == 'i' || userpath[i] == 'I'
                || userpath[i] == 'o' || userpath[i] == 'O'
                || userpath[i] == 'u' || userpath[i] == 'U')
                {
                    vowelcount++;
                }
            }
            Console.WriteLine("Vowel Count: " + vowelcount);
        }
    }
}