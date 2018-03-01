using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Substring
{
    public class Substring
    {
        public static int[] FindLongestSubstring(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("array is empty or null");
            }

            if(s.Length == 1)
            {
                int a = (int) s[0];
                return new int[] { a, 1, 0, 0 };
            }

            List<string> l = new List<string>();
            int begin = 0;
            int end = 0;

            int beginAscii = (int) s[begin];
            while(end < s.Length)
            {
                int endAscii = (int) s[end];
                if(beginAscii == endAscii)
                {
                    end++;
                }
                else
                {
                    string ss = s.Substring(begin, (end - 1) - begin + 1);
                    l.Add(ss);
                    begin = end;
                    beginAscii = (int) s[begin];
                    end++;
                }

                if(end == s.Length)
                {
                    string ss = s.Substring(begin, (end - 1) - begin + 1);
                    l.Add(ss);
                }
            }

            string lss = l.OrderByDescending(r => r.Length).First();
            int ascii = (int) lss[0];
            int d = lss.Length;
            int b = s.IndexOf(lss);
            int e = b + d;
            return new int[] { ascii, d, b, e - 1 };
        }
    }
}
