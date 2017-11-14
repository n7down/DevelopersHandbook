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
        [InlineData(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
        public void Given_UnsortedOddNumberElementsArray_Expect_SortedArray(int[] i, int[] e)
        {
            int[] a = MergeSort.Sort(i);
            Assert.True(Enumerable.SequenceEqual(e, a), "Actual: " + PrintArray(a));
        }

        [Theory]
        [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
        public void Given_UnsortedEvenNumberElementsArray_Expect_SortedArray(int[] i, int[] e)
        {
            int[] a = MergeSort.Sort(i);
            Assert.True(Enumerable.SequenceEqual(e, a), "Actual: " + PrintArray(a));
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_NullOrEmptyArray_Expected_ThrowArgumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => MergeSort.Sort(i));
        }
    }
}
