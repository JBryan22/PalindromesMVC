using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Palindromes.Models;
using System;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void CheckPalindrome_ChecksNonPalindrome_False()
    {
      Palindrome newWord = new Palindrome("dog");
      bool expected = false;
      bool actual = newWord.CheckPalindrome();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CheckPalindrome_CheckPalindrome_True()
    {
      Palindrome newWord = new Palindrome("racecar");
      bool expected = true;
      bool actual = newWord.CheckPalindrome();
      Assert.AreEqual(expected, actual);
    }
  }
}
