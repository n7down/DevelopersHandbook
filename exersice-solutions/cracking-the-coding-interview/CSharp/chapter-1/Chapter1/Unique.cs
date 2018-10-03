using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    public static class Unique
    {
        public static bool IsUnique(string s)
        {
            var results = s.GroupBy(t => t).ToDictionary(t => t.Key, t => t.Count());
            foreach(char c in s)
            {
                if(results.ContainsKey(c) && results[c] > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}