using System;
using System.IO;

namespace lab_4
{
    class Program
    {
        public static string path;
        public static string newfilepath;
        public static int userchoice;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("String Values");
                Console.WriteLine("1. Get string values from file. ");
                Console.WriteLine("2. Create a new file");
                Console.WriteLine("Press any other number to exit.");
                Console.Write("Pick: ");

            } while (!int.TryParse(Console.ReadLine(), out userchoice));

            if (userchoice.Equals(1))
            {
                do
                {
                    Console.Clear();
                    GetPath();

                } while (!File.Exists(path));

                if (File.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine("File Exists.");
                    Console.WriteLine("Your file contains: \n" + File.ReadAllText(path));

                    int words = File.ReadAllText(path).Split().Length; // word count
                    Console.WriteLine("Amount of Words: " + words);

                    VowelCounter(path); // vowel count
                    Value.StringValue(path); // string value; A = 1, B = 2, Z = 26
                }
            }
            if (userchoice.Equals(2))
            {
                Console.Clear();
                CreateFile();

            }

        }


        public static void GetPath()
        {
            Console.WriteLine("String Values");
            Console.WriteLine();

            Console.Write("Enter the path of your file containing strings: ");
            path = @"" + Console.ReadLine();
        }

        public static void CreateFile()
        {
            do // does this until it gets a valid new file path
            {
                Console.Clear();
                Console.WriteLine("Enter file path for your new file: ");
                Console.WriteLine("EX: c:\\Users\\John\\Desktop\\NewFile.txt");

                newfilepath = @"" + Console.ReadLine();
            } while (File.Exists(newfilepath));

            if (!File.Exists(newfilepath))
            {
                File.Create(newfilepath);
                Console.WriteLine("File Created!");
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