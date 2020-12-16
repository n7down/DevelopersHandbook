using System;
using Xunit;

namespace Chapter1.Tests
{
    public class URLifyTests
    {
        [Fact]
        public void Given_String_Return_URLified_String()
        {
            string s = "Mr John Smith             ";
            int length = 13;
            var actual = URLify.URLifyString(s, length);
            var expected = "Mr%20John%20Smith";
            Assert.Equal(actual, expected);
        }
    }
}
