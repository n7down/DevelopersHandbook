using Xunit;

namespace Chapter1.Tests
{
    public class OneAwayTests
    {
        [Theory]
        [InlineData("pale", "ple")]
        [InlineData("pales", "pale")]
        [InlineData("pale", "bale")]
        public void Given_Two_Strings_And_One_String_Is_One_Away_From_The_Other_CheckOneAway_Returns_True(string s, string t)
        {
            var actual = OneAway.CheckOneAway(s, t);
            Assert.True(actual, string.Format(@"for values '{0}' and '{1}' CheckOneAway should return true", s, t));
        }

        [Theory]
        [InlineData("pale", "bake")]
        [InlineData("pale", "pale")]
        public void Given_Two_Strings_And_One_String_Is_Not_One_Away_From_The_Other_CheckOneAway_Returns_False(string s, string t)
        {
            var actual = OneAway.CheckOneAway(s, t);
            Assert.False(actual, string.Format(@"for values '{0}' and '{1}' CheckOneAway should return false", s, t));
        }
    }
}