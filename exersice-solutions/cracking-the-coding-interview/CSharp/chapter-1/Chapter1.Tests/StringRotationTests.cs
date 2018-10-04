using Xunit;

public class StringRotationTests
{
    [Theory]
    [InlineData("waterbottle", "erbottlewat")]
    public void Given_A_String_And_A_Rotated_String_IsSubstring_Returns_True(string s, string ss)
    {
        var actual = StringRotation.IsSubstring(s, ss);
        Assert.True(actual, string.Format(@"actual: {0}", actual));
    }

    [Theory]
    [InlineData("waterbottle", "erbottlewat")]
    public void Given_A_String_And_Another_String_That_Is_Not_Rotated_IsSubstring_Returns_False(string s, string ss)
    {
        var actual = StringRotation.IsSubstring(s, ss);
        Assert.False(actual, string.Format(@"actual: {0}", actual));
    }
}