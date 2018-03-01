using System;
using Xunit;

namespace MaximumProductSubarray.Tests
{
    public class MaximumProductTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expect_ThrowsArguementException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => Subarray.MaximumProduct(i));
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 2, 3 }, 6)]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        public void Given_ValidArray_Expect_ReturnsMaximumProduct(int[] d, int e)
        {
            int a = Subarray.MaximumProduct(d);
            Assert.True(a == e, "Expected: " + e + " Actual: " + a);
        }
    }
}
