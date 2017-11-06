using System;
using System.Linq;
using Xunit;

namespace Substring.Tests
{
    public class FindSubstringTest
    {
        [Theory]
        [InlineData("11", new int[] { 49, 2, 0, 1 })]
        [InlineData("1111aa994bbbb1111AAAAAFF?<mmMaaaaaaaaaaaaaaaaaaaaaaaaabf", new int[] {97, 25, 29, 53})]
        public void Given_StringWithCharacters_Expect_ArrayWithDataAboutSubstring(string s, int[] e)
        {
            int[] r = Substring.FindSubstring(s);
            Assert.True(Enumerable.SequenceEqual(r, e));
        }

        [Theory]
        [InlineData("", new int[] { 0, 0, 0, 0 })]
        public void Given_EmptyString_Expect_ThrowsIllegalArgumentException(string s, int[] e)
        {
            Assert.Throws<ArgumentException>(() => Substring.FindSubstring(s));
        }

        [Theory]
        [InlineData("1", new int[] { 49, 0, 1, 1 })]
        public void Given_StringWithLengthOne_Expect_ThrowsIllegalArgumentException(string s, int[] e)
        {
            Assert.Throws<ArgumentException>(() => Substring.FindSubstring(s));
        }
    }
}
