using System;
using System.IO;
namespace new_program
{
    class Program
    {
        public static void NewMenu()
        {
            Console.WriteLine("Welcome to the password checker");
            Console.WriteLine("1.To Check your password");
            Console.WriteLine("2.To exit");
            if (Console.ReadLine() == "1")
            {
                Passwordcheck();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static void Passwordcheck()
        {
            string password1 = "";
            Console.Write("Enter the password you want to check: ");
            password1 = Console.ReadLine();
            Console.WriteLine("You put {0}", password1);
            Console.Write("Enter the wordlist path: ");
            string path = "";
            path = Console.ReadLine();
            int counter = 0;
            var linesRead = File.ReadLines(path);
            foreach (string lineRead in linesRead)
            {
                if (lineRead == password1)
                {
                    Console.WriteLine("Your password is {0} the amount of passwords it took to find yours was {1}", lineRead, counter);
                    Passwordcheck();
                }
                else
                {
                    counter += 1;
                    continue;
                }
            }
        }
        
        void Main(string[] args)
        {
            NewMenu();
        }

    };
}
