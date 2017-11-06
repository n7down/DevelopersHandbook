using System;
using System.Linq;
using Xunit;

namespace ProductOfArrayExceptSelf.Tests
{
    public class FindProductExceptSelfTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        [InlineData(new int[] {-1})]
        [InlineData(new int[] {0})]
        public void Given_ArrayWithBadArguements_Expect_ThrowArgumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => ProductOfArrayExceptSelf.FindProductExceptSelf(i));
        }

        [Theory]
        [InlineData(new int[] {1, 2, 3, 4}, new int[] {24, 12, 8, 6})]
        public void Given_ValidArray_Expect_ArrayWhereEveryElementIsProductOfAllElementsExceptSelf(int[] i, int[] e)
        {
            int[] r = ProductOfArrayExceptSelf.FindProductExceptSelf(i);
            Assert.True(Enumerable.SequenceEqual(r, e));
        }
    }
}
