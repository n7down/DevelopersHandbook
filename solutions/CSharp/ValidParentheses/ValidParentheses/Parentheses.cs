using System;
using System.Collections;

namespace ValidParentheses
{
    public class Parentheses
    {
        static public bool IsValid(string s)
        {
            int sLength = s.Length;
            if(sLength % 2 != 0)
            {
                return false;
            }

            if(sLength == 0)
            {
                return false;
            }

            int midPoint = sLength / 2;

            int i = 0;
            Stack stack = new Stack();
            foreach(char c in s)
            {
                i++;
                if(stack.Count == 0)
                {
                    stack.Push(c);
                }
                else
                {
                    if(i > midPoint)
                    {
                        if(stack.Peek().Equals('{') && c.Equals('}'))
                        {
                            stack.Pop();
                        }
                        else if(stack.Peek().Equals('(') && c.Equals(')'))
                        {
                            stack.Pop();
                        }
                        else if(stack.Peek().Equals('[') && c.Equals(']'))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
            }
            return true;
        }
    }
}
