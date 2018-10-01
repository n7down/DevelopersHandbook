using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chapter1
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = Regex.Replace(s, @"\s+", "");
            if(s.Length == 0)
            {
                return true;
            }
            else if(s.Length == 1)
            {
                return true;
            }
            else if(s.Length == 2)
            {
                return false;
            }
            else 
            {
                Stack<char> stack = new Stack<char>();
                for(int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    stack.Push(c);
                }

                int middle = s.Length / 2;
                
                return false;
            }
        }
    }
}
