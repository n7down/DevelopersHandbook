using Xunit;

namespace Chapter1.Tests
{
    public class UniqueTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("ab")]
        [InlineData("abc")]
        public void Given_A_String_That_Has_Unique_Characters_IsUnique_Returns_True(string s)
        {
            var actual = Unique.IsUnique(s);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("aa")]
        [InlineData("aba")]
        [InlineData("abccc")]
        public void Given_A_String_That_Does_Not_Have_Unique_Characters_IsUnique_Returns_False(string s)
        {
            var actual = Unique.IsUnique(s);
            Assert.False(actual);
        }
    }
}