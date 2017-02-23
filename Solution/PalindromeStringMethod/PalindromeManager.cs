using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStringMethod
{
    public class PalindromeManager
    {
        private static List<string> PalindromeArray;

        public PalindromeManager()
        {
            PalindromeArray = new List<string>();
        }

        /// <summary>
        /// Function that return all palindromes string from input string
        /// </summary>
        /// <param name="input">string input</param>
        /// <param name="getUniqueString">remove the palindrom contained in each other</param>
        /// <param name="descSort">Indicate the sort direction</param>
        /// <returns></returns>
        public string[] FindAllPalindrome(string input, bool getUniqueString = false,bool descSort=false)
        {
            int min = 1;
            if (string.IsNullOrEmpty(input) || input.Trim().Length == 0)
            {
                return PalindromeArray.ToArray();
            }
            for (int i = 0; i < input.Length - min; i++)
            {
                for (int j = input.Length - min; j > i + min; j--)
                {
                    string str = input.Substring(i, j - i);
                    string revStr = new string(str.Reverse().ToArray());

                    if (str == revStr && (str.Length > min))
                    {
                        if (getUniqueString)
                        {
                            if (isUnique(PalindromeArray, str))
                                PalindromeArray.Add(str);
                        }
                        else
                        {
                            PalindromeArray.Add(str);
                        }
                    }
                }
            }
            
            return SortList(PalindromeArray.ToArray(), descSort);
        }

        /// <summary>
        /// Function that check if palindrome already exist in input list
        /// </summary>
        /// <param name="inputList"></param>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public bool isUnique(List<string> inputList, string SearchString)
        {
            return (inputList.FirstOrDefault(stringToCheck => stringToCheck.Contains(SearchString)) == null);
        }

        /// <summary>
        /// Function that sort input array of string
        /// </summary>
        /// <param name="sourceArr"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public string[] SortList(string[] sourceArr, bool desc = false)
        {
            if (!desc)
                Array.Sort(sourceArr, (x, y) => x.Length.CompareTo(y.Length));
            else
                Array.Sort(sourceArr, (x, y) => y.Length.CompareTo(x.Length));
            return sourceArr;
        }

    }
}
