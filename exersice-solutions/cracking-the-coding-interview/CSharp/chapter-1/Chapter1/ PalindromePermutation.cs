using System;
using System.Collections;
using System.Text.RegularExpressions;

public static class PalindromePermutation
{
    public static bool CheckPalindromePermutation(string s, string p)
    {
        var isPalindrome = false;
        var isPermutation = true;
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