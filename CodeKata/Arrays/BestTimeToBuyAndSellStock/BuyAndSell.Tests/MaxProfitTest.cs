using System;
using Xunit;

namespace BuyAndSell.Tests
{
    public class MaxProfitTest
    {
        [Theory]
        [InlineData(new int[] {})]
        [InlineData(null)]
        public void Given_EmptyArray_Expect_ThrowArguementException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => Stock.MaxProfit(i));
        }

        [Theory]
        [InlineData(new int[] {7, 1, 5, 3, 6, 4}, 5)]
        [InlineData(new int[] {7, 6, 4, 3, 1}, 0)]
        public void Given_ValidArray_Expect_ReturnMaxProfit(int[] i, int e)
        {
            int r = Stock.MaxProfit(i);
            Assert.True(r == e);
        }
    }
}
