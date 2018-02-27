using System;
using Xunit;

namespace RgbToHex.Tests
{
    public class RgbTests
    {
        [Theory]
        [InlineData(new int[3] {255, 255, 255}, "FFFFFF")]
        public void Test_ConvertToHex(int[] i, string r)
        {
            string hex = Rgb.ConvertToHex(i);
            Assert.True(hex.Equals(r));
        }
    }
}
