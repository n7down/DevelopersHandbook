using System;
using System.Collections.Generic;
using System.Text;

namespace Substring
{
    public class Substring
    {
        public static int[] FindSubstring(string s)
        {
            int begin = 0;
            int end = 1;

            if(string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("array is empty or null");
            }

            if(s.Length == 1)
            {
                throw new ArgumentException("array only contains one element");
            }

            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(char c in s.ToCharArray())
            {
                if(map.ContainsKey(c))
                {
                    int v = map[c];
                    map[c] = v++;   
                }
                else
                {
                    map.Add(c, 0);
                }
            }

            // for() { /* initialize the hash map here */ }
            // while(end<s.size()){
            //     if(map[s[end++]]-- ?){  /* modify counter here */ }
            //     while(/* counter condition */){ 
            //         /* update d here if finding minimum*/
            //         //increase begin to make it invalid/valid again
            //         if(map[s[begin++]]++ ?){ /*modify counter here*/ }
            //     }  
            //     /* update d here if finding maximum*/
            // }

            int ascii = (int) s[end];
            while(end < s.Length)
            {
                if(ascii == s[end])
                {
                }
                
                end++;
            }

            int d = begin - end;
            return new int[] { ascii, d, begin, end };
        }
    }
}
