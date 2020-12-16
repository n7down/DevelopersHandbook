using Xunit;

namespace Chapter1.Tests
{
    public class CheckPermutationTests
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "b")]
        [InlineData("abc", "b")]
        [InlineData("abcd", "bc")]
        public void Given_Two_Strings_Where_One_String_Is_A_Permutation_Of_The_First_IsPermutation_Returns_True(string s, string ss)
        {
            var actual = CheckPermutation.IsPermutation(s, ss);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("a", "b")]
        [InlineData("ab", "c")]
        [InlineData("abc", "d")]
        public void Given_Two_Strings_Where_One_String_Is_Not_A_Permutation_Of_The_First_IsPermutation_Returns_False(string s, string ss)
        {
            var actual = CheckPermutation.IsPermutation(s, ss);
            Assert.False(actual);
        }
    }
}