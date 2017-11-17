using System;
using Xunit;

namespace MaximumProductSubarray.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_EmptyOrNullArray_Expect_ThrowArgumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => Subarray.MaximumProduct(i));
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 2, 4 }, 8)]
        public void Given_ValidArray_Expect_ReturnMaximumProduct(int[] i, int e)
        {
            int a = Subarray.MaximumProduct(i);
            Assert.True(e == a);
        }
    }
}
