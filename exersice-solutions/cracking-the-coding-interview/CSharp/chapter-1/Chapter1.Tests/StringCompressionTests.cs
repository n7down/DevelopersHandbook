using Xunit;

namespace Chapter1.Tests
{
    public class StringCompressionTests
    {
        [Theory]
        [InlineData("aaa", "a3")]
        [InlineData("aabbccc", "a2b2c3")]
        [InlineData("aabcccccaaa", "a2b1c5a3")]
        public void Given_A_String_Return_A_Compressed_String(string s, string t)
        {
            var actual = StringCompression.CompressString(s);
            Assert.True(t.Equals(actual), string.Format(@"actual: {0}", s));
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ab")]
        [InlineData("abc", "abc")]
        [InlineData("abcd", "abcd")]
        public void Given_A_String_That_Can_Not_Be_Compressed_Return_Original_String(string s, string t)
        {
            var actual = StringCompression.CompressString(s);
            Assert.True(t.Equals(actual));
        }
    }
}