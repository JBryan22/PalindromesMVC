using System;
using System.Collections.Generic;

namespace Palindromes.Models
{
  public class Palindrome
  {
    private string _userInput;
    private bool _isPalindrome;

    public Palindrome(string userInput)
    {
      _userInput = userInput;
    }

    public bool CheckPalindrome()
    {
      List<string> reversedInput = new List<string>{};

      for (int i = _userInput.Length - 1; i >= 0; i--)
      {
        reversedInput.Add(_userInput[i].ToString());
      }

      string reversedString = String.Join("", reversedInput);

      return reversedString == _userInput;
    }
  }
}
