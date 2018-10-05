using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class PalindromePermutation
{
    public static IEnumerable<string> GetPermutations(string s)
    {
        // permutations - https://stackoverflow.com/questions/16907040/how-to-use-query-syntax-to-create-permutations
        if (s.Length == 1) 
        {
            return new List<string> { s };
        }
        var permutations = from c in s
                        from p in GetPermutations(new String(s.Where(x => x != c).ToArray()))
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

        

        return isPalindrome && isPermutation;
    }
}