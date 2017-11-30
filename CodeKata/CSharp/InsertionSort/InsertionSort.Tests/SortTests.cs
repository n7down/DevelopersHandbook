using System;
using System.Linq;
using System.Text;
using Xunit;

namespace InsertionSort.Tests
{
    public class SortTests
    {
        private string PrintArray(int[] d)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach(int a in d)
            {
                sb.Append(a.ToString());
                sb.Append(" ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expected_ThrowsArgumentException(int[] d)
        {
            Assert.Throws<ArgumentException>(() => InsertionSort.Sort(d));
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 12, 11, 13, 5, 6 }, new int[] { 5, 6, 11, 12, 13 })]
        public void Given_UnsortedArray_Expected_SortedArray(int[] d, int[] e)
        {
            int[] a = InsertionSort.Sort(d);
            Assert.True(Enumerable.SequenceEqual(e, a), "Actual: " + PrintArray(a));
        }
    }
}
