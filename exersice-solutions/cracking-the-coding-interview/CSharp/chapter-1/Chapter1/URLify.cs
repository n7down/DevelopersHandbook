using System;
using System.Text.RegularExpressions;

namespace Chapter1
{
    public static class URLify
    {
        public static string URLifyString(string s, int length)
        {
            s = s.Trim();
            s = Regex.Replace(s, @" ", "%20");
            return s;
        }
    }
}
