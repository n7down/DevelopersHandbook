using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class PalindromePermutation
{
    // http://loekvandenouweland.com/content/Permutations-with-C-sharp-and-LINQ.html
    // https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer
    private static IEnumerable<string> Permutate(string source)
    {
        if (source.Length == 1) return new List<string> { source };

        var permutations = from c in source
                            from p in Permutate(new String(source.Where(x => x != c).ToArray()))
                            select c + p;

        return permutations;
    }

    public static bool CheckPalindromePermutation(string s, string p)
    {
        var isPalindrome = false;
        var isPermutation = false;
        var ps = Regex.Replace(p, @"\s+", "");
        if(s.Length == 0 || s.Length == 1)
        {
            isPalindrome = true;
        }
        else
        {
            string first = ps.Substring(0, ps.Length / 2);
            char[] a = ps.ToCharArray();
            Array.Reverse(a);
            string second = new string(a);
            second = second.Substring(0, second.Length / 2);
            isPalindrome = first.Equals(second);
        }

        var ss = s.Split(' ');
        var pp = p.Split(' ');
        if(ss.Length != pp.Length)
        {
            isPermutation = false;
        }
        for(int i = 0; i < ss.Length; i++)
        {
            var perm = Permutate(ss[i]);
            if(perm.Contains(pp[i]))
            {
                isPermutation = true;
            }
        }

        return isPalindrome && isPermutation;
    }
}