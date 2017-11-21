using System;
using System.Linq;
using Xunit;

namespace FindMinimumInRotatedSortedArray.Tests
{
    public class FindMinimumTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expected_ThrowsArgumentException(int[] d)
        {
            Assert.Throws<ArgumentException>(() => SortedArray.FindMinimum(d));
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 3, 4, 1, 2 }, 1)]
        public void Given_UnsortedArray_Expected_SortedArray(int[] d, int e)
        {
            int a = SortedArray.FindMinimum(d);
            Assert.True(a == e, "Actual: " + a);
        }
    }
}
