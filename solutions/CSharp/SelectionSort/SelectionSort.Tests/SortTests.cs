using System;
using Xunit;
using System.Linq;
using System.Text;

namespace SelectionSort.Tests
{
    public class SortTests
    {
        private string PrintArray(int[] d)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach(int i in d)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expect_ThrowsArgumentException(int[] d)
        {
            Assert.Throws<ArgumentException>(() => SelectionSort.Sort(d));
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 64, 25, 12, 22, 11 }, new int[] { 11, 12, 22, 25, 64 })]
        public void Given_UnsortedArray_Expect_SortedArray(int[] d, int[] e)
        {
            int[] a = SelectionSort.Sort(d);
            Assert.True(Enumerable.SequenceEqual(a, e), "Actual: " + PrintArray(a));
        }
    }
}
