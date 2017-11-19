using System;
using System.Linq;
using System.Text;
using Xunit;

namespace BubbleSort.Tests
{
    public class SortTests
    {
        private string PrintArray(int[] d)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach(int a in d)
            {
                sb.Append(a);
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
            Assert.Throws<ArgumentException>(() => BubbleSort.Sort(d)); 
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
        public void Given_UnsortedArray_Expect_SortedArray(int[] d, int[] e)
        {
            int[] a = BubbleSort.Sort(d);
            Assert.True(Enumerable.SequenceEqual(a, e), "Actual: " + PrintArray(a));
        }
    }
}
