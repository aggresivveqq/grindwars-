using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Digit(this string s)
    {
      return s != null && s.Length == 1 && char.IsDigit(s[0]);

      }
}
