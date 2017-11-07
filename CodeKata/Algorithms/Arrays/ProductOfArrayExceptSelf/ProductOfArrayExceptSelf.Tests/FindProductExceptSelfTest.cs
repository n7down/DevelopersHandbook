using System;
using System.Linq;
using System.Text;
using Xunit;

namespace ProductOfArrayExceptSelf.Tests
{
    public class FindProductExceptSelfTest
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
        [InlineData(null)]
        [InlineData(new int[] {})]
        public void Given_ArrayWithBadArguements_Expect_ThrowArgumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => ProductOfArrayExceptSelf.FindProductExceptSelf(i));
        }

        [Theory]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 6, 3, 2 })]
        [InlineData(new int[] {1, 2, 3, 4}, new int[] {24, 12, 8, 6})]
        public void Given_ValidArray_Expect_ArrayWhereEveryElementIsProductOfAllElementsExceptSelf(int[] i, int[] e)
        {
            int[] a = ProductOfArrayExceptSelf.FindProductExceptSelf(i);
            Assert.True(Enumerable.SequenceEqual(a, e), "Actual: " + PrintArray(i));
        }
    }
}
