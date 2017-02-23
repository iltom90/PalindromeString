using PalindromeStringMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        private const int firstNelements = 3; // const used to limit showed palindrimes
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine($"Welcome to first 3 longest palindrome finder");
            Console.WriteLine($"Choose one of the following options and press enter:");
            Console.WriteLine($"1- Test the given string 'sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop'");
            Console.WriteLine($"2- Input and test your own string");
            string inputcomand = Console.ReadLine();
            switch (inputcomand)
            {
                case "1":
                    FindPalindrome("sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"Write your string and press enter");
                    string inputString = Console.ReadLine();
                    FindPalindrome(inputString);
                    break;
                default:
                    Console.WriteLine("Command not recognised! please enter a valid choice.");
                    Console.WriteLine("Press enter to restart application");
                    Console.ReadLine();
                    goto start;
            }

            Console.WriteLine($"Press any key to restart or ESC to close");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    goto start;
            }
        }

        /// <summary>
        /// Method used to show the <const name="firstNelements"> longest unique palindromes string of input parameter
        /// </summary>
        /// <param name="inputString"></param>
        public static void FindPalindrome(string inputString)
        {
            PalindromeManager palMan = new PalindromeManager();
            string[] res = palMan.FindAllPalindrome(inputString, true, true);

            // Check if exist almost <const name="firstNelements"> elements in result array
            if (res.Length >= firstNelements)
            {
                for(int i =0;i < firstNelements;i++)
                {
                    Console.WriteLine("Text: " + res[i] + ", Index: " + inputString.IndexOf(res[i]) + ", Length: " + res[i].Length);
                };
            }
            else
            {
                Console.WriteLine($"ERROR: input string doesn't contain {firstNelements} palindrome strings");
            }
        }
    }
}

