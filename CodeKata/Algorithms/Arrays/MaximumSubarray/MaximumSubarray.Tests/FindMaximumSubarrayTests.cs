using System;
using Xunit;

namespace MaximumSubarray.Tests
{
    public class FindLargestSumOfContiguousSubarray
    {
        [Theory]
        [InlineData(new int[] {0}, 0)]
        [InlineData(new int[] {5}, 5)]
        [InlineData(new int[] {-1, 2}, 2)]
        [InlineData(new int[] {2, -1}, 2)]
        [InlineData(new int[] {-2, -3, 1}, 1)]
        [InlineData(new int[] {-2, 1,  -3, 4, -1, 2, 1, -5, 4}, 6)]
        public void Given_ValidArray_Expect_LargestSum(int[] i, int e)
        {
            int a = Subarray.FindLargestSumOfContiguousSubarray(i);
            Assert.True(a == e, "Actual: " + a);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_InvalidArray_Expect_ThrowsArgumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => Subarray.FindLargestSumOfContiguousSubarray(i));
        }

        [Theory]
        [InlineData(new int[] {-2, -1, -3}, -1)]
        [InlineData(new int[] {-1, -2, -3, -6, -13}, -1)]
        public void Given_ArrayWithNegitiveValues_Expect_NumberInArrayWithSmallestMagnitude(int[] i, int e)
        {
            int a = Subarray.FindLargestSumOfContiguousSubarray(i);
            Assert.True(a == e, "Actual: " + a);
        }

        [Theory]
        [InlineData(new int[] {1, 2, 6}, 9)]
        [InlineData(new int[] {2, 6}, 8)]
        public void Given_ArrayWithPositiveValues_Expect_NumberInArrayWithSmallestMagnitude(int[] i, int e)
        {
            int a = Subarray.FindLargestSumOfContiguousSubarray(i);
            Assert.True(a == e, "Actual: " + a);    
        }
    }
}
