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
                Queue<char> queue = new Queue<char>();
                for(int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    queue.Enqueue(c);
                }

                Stack<char> stack = new Stack<char>();
                int middle = s.Length / 2;
                for(int i = 0; i < middle; i++)
                {
                    char c = queue.Dequeue();
                    stack.Push(c);
                }

                if(s.Length % 2 != 0)
                {
                    queue.Dequeue();
                }

                for(int i = 0; i < queue.Count;)
                {
                    char c0 = stack.Pop();
                    char c1 = queue.Dequeue();
                    if(c0.Equals(c1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
    }
}
