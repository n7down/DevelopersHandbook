using System;
using System.Linq;
using Xunit;

namespace Heapsort.Tests
{
    public class SortTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expect_ThrowsArgumentException(int[] d)
        {
            Assert.Throws<ArgumentException>(() => Heapsort.Sort(d));
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
        public void Given_UnsortedArray_Expect_SortedArray(int[] d, int[] e)
        {
            int[] a = Heapsort.Sort(d);
            Assert.True(Enumerable.SequenceEqual(a, e));
        }
    }
}
