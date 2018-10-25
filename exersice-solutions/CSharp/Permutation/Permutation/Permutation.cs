using System;
using System.Collections.Generic;

namespace Permutation
{
    // TODO: finish this - https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer
    // https://www.codeproject.com/Articles/43767/A-C-List-Permutation-Iterator
    public class Permutation
    {
        private static List<string> Merge(List<string> s, string c)
        {
            List<string> r = new List<string>();
            foreach(string ss in s)
            {

            }
            return r;
        }
        
        public static int[,] GetPermutations(int [] c)
        {
            return new int[,] {{}};
        }

        public static List<string> GetPermutations(string s)
        {
            List<string> r = new List<string>();
            if(s.Length == 1)
            {
                r.Add(s);
            }
            else
            {
                int lastIndex = s.Length - 1;
                string last = s.Substring(lastIndex);
                string rest = s.Substring(0, lastIndex);
                r = Merge(GetPermutations(rest), last);
            }
            return r;
        }
    }
}
