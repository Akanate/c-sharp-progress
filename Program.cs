using System;
using System.IO;
namespace Class1
{
    class Program
    {
        public void Main_menu()
        {
            Console.WriteLine("Welcome to the password checker");
            Console.WriteLine("1.To Check your password");
            Console.WriteLine("2.To exit");
            var classed = new Program();
            if (Console.ReadLine() == "1")
            {
                classed.password_check();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public void password_check()
        {
            string password1 = "";
            var classes = new Program();
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
                    Console.WriteLine("Your password is {0} the amount of passwords it took to find yours was {1}", lineRead,counter);
                    classes.password_check();
                } else
                {
                    counter += 1;
                    continue;
                }
            }
        }

        private static void Main(string[] args)
        {
            var class1 = new Program();
            class1.Main_menu();
        }

    };
}
