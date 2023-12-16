// reverse a string

using System;
using System.Linq;

public static class Kata
{
  public static string Solution(string str) 
  {
    string reversedStr = new string(str.Reverse().ToArray());
    return reversedStr;
  }
}