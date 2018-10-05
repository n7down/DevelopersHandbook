using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class PalindromePermutation
{
    public static IEnumerable<IEnumerable<T>> Permuatations<T>(this IEnumerable<T> source)
    {
        var list = source.ToList();//becase we iterate it multiple times
        return list.SelectMany((item, i) => list.Where((_, index) => index != i)
                .Permuatations()
                .Select(subsequence => new[] { item }.Concat(subsequence)))
            .DefaultIfEmpty(Enumerable.Empty<T>());
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
            IEnumerable<string> perm = GetPermutations(ss[i]);
            if(perm.Contains(pp[i]))
            {
                isPermutation = true;
            }
        }

        return isPalindrome && isPermutation;
    }
}