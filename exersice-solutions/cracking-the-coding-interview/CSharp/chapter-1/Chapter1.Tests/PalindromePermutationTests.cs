using Xunit;

namespace Chapter1.Tests
{
    public class PalindromePermutationTests
    {
        [Theory]
        [InlineData("taco cat", "atco cta")]
        public void Given_A_Palindrome_And_Permutation_CheckPalindromePermutation_Returns_True(string s, string p)
        {
            var actual = PalindromePermutation.CheckPalindromePermutation(s, p);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("", "")]
        public void Given_A_Palindrome_And_Permutation_CheckPalindromePermutation_Returns_False(string s, string p)
        {
            Assert.True(false);
        }
    }
}
