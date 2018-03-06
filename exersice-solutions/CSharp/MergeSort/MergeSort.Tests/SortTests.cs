using System;
using System.Linq;
using System.Text;
using Xunit;

namespace MergeSort.Tests
{
    public class SortTests
    {
        private string PrintArray(int[] i)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach(int a in i)
            {
                sb.Append(a.ToString());
                sb.Append(" ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 1, 2 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 38, 27, 43, 3, 9, 82, 10 }, new int[] { 3, 9, 10, 27, 38, 43, 82 })]
        public void Given_UnsortedArray_Expect_SortedArray(int[] i, int[] e)
        {
            int[] a = MergeSort.Run(i);
            Assert.True(Enumerable.SequenceEqual(e, a), "Actual: " + PrintArray(a));
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expected_ThrowArgumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => MergeSort.Run(i));
        }
    }
}
