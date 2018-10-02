using System;
using Xunit;

namespace Chapter1.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("aba")]
        [InlineData("abcba")]
        public void Given_A_String_That_Is_A_Palindrome_Return_IsPalindrome_True(string s)
        {
            bool actual = Palindrome.IsPalindrome(s);
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abc")]
        public void Given_A_String_That_Is_Not_A_Palindrome_Return_IsPalindrome_False(string s)
        {
            bool actual = Palindrome.IsPalindrome(s);
            bool expected = false;
            Assert.Equal(actual, expected);
        }
    }
}
