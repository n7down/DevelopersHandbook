using System;
using System.Linq;
using Xunit;

namespace Substring.Tests
{
    public class FindLongestSubstringTest
    {
        [Theory]
        [InlineData("1", new int[] { 49, 1, 0, 0 })]
        [InlineData("11", new int[] { 49, 2, 0, 1 })]
        [InlineData("aa1111", new int[] { 49, 4, 2, 5})]
        [InlineData("1111aa994bbbb1111AAAAAFF?<mmMaaaaaaaaaaaaaaaaaaaaaaaaabf", new int[] {97, 25, 29, 53})]
        public void Given_StringWithCharacters_Expect_ArrayWithDataAboutSubstring(string s, int[] e)
        {
            int[] r = Substring.FindLongestSubstring(s);
            Assert.True(Enumerable.SequenceEqual(r, e), "results: [" + r[0] + ", " + r[1] + ", " + r[2] + ", " + r[3] + "]");
        }

        [Theory]
        [InlineData("", new int[] { 0, 0, 0, 0 })]
        public void Given_EmptyString_Expect_ThrowsIllegalArgumentException(string s, int[] e)
        {
            Assert.Throws<ArgumentException>(() => Substring.FindLongestSubstring(s));
        }
    }
}
