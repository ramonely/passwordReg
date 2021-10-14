using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordReg
{
    internal class Program
    {
        public static string getPassword(string prompt)
        {
            Console.WriteLine(prompt);
            string password = Console.ReadLine();
            bool checker = true;

            while (checker)
            {
                if (password.Any(char.IsUpper) && password.Any(char.IsNumber) && password.Any(char.IsLower)
                    && password.Length >= 7 && password.Length <= 12 == true)
                {
                    checker = false;
                }
                else
                {
                    Console.WriteLine("\nThe password must contain at:\n" +
                        "\nLeast one uppercase letter" +
                        "\nAt least one lowercase letter" +
                        "\nAt least a minimum of 7 characters" +
                        "\nNo more than 12 chracters" +
                        "\n\nTry Again:");
                    password = Console.ReadLine();
                }
            }
            return password;
        }

        public static string getUser(string prompt)
        {
            Console.WriteLine(prompt);
            string username = Console.ReadLine();
            bool checker = true;

            while (checker)
            {
                if (username.Any(char.IsUpper) && username.Any(char.IsNumber) && username.Any(char.IsLower)
                    && username.Length >= 7 && username.Length <= 12 && username.Any(char.IsLetter) == true)
                {
                    checker = false;
                }
                else
                {
                    Console.WriteLine("\nThe username must contain at:\n" +
                        "\nMust have at least 5 letters" +
                        "\nAt least one number" +
                        "\nAt least a minimum of 7 characters" +
                        "\nNo more than 12 chracters" +
                        "\n\nTry Again:");
                    username = Console.ReadLine();
                }
            }

            return username;
        }

        public static void another()
        {
            Console.WriteLine("Do you want the enter another username and ");
        }

        private static void Main()
        {
            List<string> names = new List<string>();
            List<string> passes = new List<string>();

            bool checker = true;
            while (checker)
            {
                // List<string> names = new List<string>();
                // List<string> passes = new List<string>();

                string username = getUser("Enter your new username:");
                Console.WriteLine("");
                string password = getPassword("Enter your new password:");

                names.Insert(0, username);
                passes.Insert(0, password);

                Console.WriteLine("\nDo you want to add another username and password? (yes or no)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Console.WriteLine("");
                    checker = true;
                }
                else if (answer == "no")
                {
                    checker = false;
                }
                else
                {
                    Console.WriteLine("Plase only enter yes or no:");
                    answer = Console.ReadLine();
                }
            }

            Console.WriteLine("\n==Username==\t==Password==\n");

            for (int n = 0; n < names.Count; n++)
            {
                Console.WriteLine(string.Format($"{names[n],0}\t{passes[n],15}"));
            }

            Console.WriteLine("\nTest when calling matching index:");
            Console.WriteLine("\n==Username==\t==Password==\n");
            Console.WriteLine(string.Format($"{names[2],0}\t{passes[2],15}"));
            Console.WriteLine(string.Format($"{names[4],0}\t{passes[4],15}"));
        }
    }
}