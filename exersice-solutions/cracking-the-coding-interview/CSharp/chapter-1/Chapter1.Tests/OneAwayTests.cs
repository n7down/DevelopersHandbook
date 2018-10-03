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
            Assert.True(actual);
        }

        [Theory]
        [InlineData("pale", "bake")]
        public void Given_Two_Strings_And_One_String_Is_Not_One_Away_From_The_Other_CheckOneAway_Returns_False(string s, string t)
        {
            var actual = OneAway.CheckOneAway(s, t);
            Assert.False(actual);
        }
    }
}