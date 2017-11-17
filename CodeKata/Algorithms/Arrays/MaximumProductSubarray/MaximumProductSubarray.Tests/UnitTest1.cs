using System;
using Xunit;

namespace MaximumProductSubarray.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expect_ThrowsArguementException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => MaximumProductSubarray.MaximumProduct(i));
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 2, 3 }, 6)]
        public void Given_ValidArray_Expect_ReturnsMaximumProduct(int[] i, int e)
        {
            int a = MaximumProductSubarray.MaximumProduct(i);
            Assert.True(a == e, "Expected: " + e + " Actual: " + a);
        }
    }
}
