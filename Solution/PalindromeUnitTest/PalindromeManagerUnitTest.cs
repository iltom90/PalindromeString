using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeStringMethod;

namespace PalindromeUnitTest
{
    [TestClass]
    public class PalindromeManagerUnitTest
    {
        private PalindromeManager pm { get; set; }
        public PalindromeManagerUnitTest()
        {
            pm = new PalindromeManager();
        }
        [TestMethod]
        public void TestFindAllPalindrome()
        {
            string[] result = pm.FindAllPalindrome("123");
            Assert.AreEqual(0,result.Length,"Should not find palindrome in string");
        }

        [TestMethod]
        public void TestFindAllPalindromeSpace()
        {
            string[] result = pm.FindAllPalindrome("                ");
            Assert.AreEqual(0, result.Length, "a string with white spaces should not considered palindrom");
        }

        [TestMethod]
        public void TestFindAllPalindromeNull()
        {
            string[] result = pm.FindAllPalindrome(null);
            Assert.AreEqual(0, result.Length, "a null string should not considered palindrom");
        }

        [TestMethod]
        public void TestFindAllPalindromeEmpty()
        {
            string[] result = pm.FindAllPalindrome("");
            Assert.AreEqual(0, result.Length, "an Empty string should not considered palindrom");
        }        
    }
}
