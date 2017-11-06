using System;
using Xunit;
using ValidParentheses;

namespace ValidParentheses.Tests
{
    public class ParenthesesTests
    {
        public ParenthesesTests()
        {

        }

        [Theory]
        [InlineData("{}", true)]
        [InlineData("[]", true)]
        [InlineData("()", true)]
        [InlineData("[{}]", true)]
        [InlineData("{([])}", true)]
        public void When_StringContainsOpeningAndClosingBraces_Expect_IsValidAsTrue(string s, bool isValid)
        {
            Assert.True(Parentheses.IsValid(s) == isValid);
        }

        [Theory]
        [InlineData("{)", false)]
        public void When_StringContainsOpeningAndClosingBraces_Expect_IsValidAsFalse(string s, bool isValid)
        {
            Assert.True(Parentheses.IsValid(s) == isValid);
        }

        [Theory]
        [InlineData("{])", false)]
        public void When_StringContainsOddLength_Expect_IsValidAsFalse(string s, bool isValid)
        {
            Assert.True(Parentheses.IsValid(s) == isValid);
        }

        [Theory]
        [InlineData("", false)]
        public void When_StringIsEmpty_Expect_IsValidAsFalse(string s, bool isValid)
        {
            Assert.True(Parentheses.IsValid(s) == isValid);
        }
    }
}
