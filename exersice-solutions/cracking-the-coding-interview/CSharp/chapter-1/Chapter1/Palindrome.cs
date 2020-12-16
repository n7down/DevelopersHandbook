using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chapter1
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            bool isPalindrome = false;
            if(s.Length == 0 || s.Length == 1)
            {
                isPalindrome = true;
            }
            else
            {
                string first = s.Substring(0, s.Length / 2);
                char[] a = s.ToCharArray();
                Array.Reverse(a);
                string second = new string(a);
                second = second.Substring(0, second.Length / 2);

                isPalindrome = first.Equals(second);
            }
            return isPalindrome;
        }
    }
}
