using System;
using System.Linq;
using Xunit;

namespace TwoSum.Tests
{
    public class FindSumTest
    {
        [Theory]
        [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {2, 7})]
        public void Given_ArrayOfIntAndTarget_Expect_FindTwoIntThatSumUpToTarget(int[] i, int t, int[] s)
        {
            int[] sums = TwoSum.FindSum(i, t);
            Assert.True(Enumerable.SequenceEqual(sums, s));
        }

        [Theory]
        [InlineData(new int[] {}, 0)]
        [InlineData(new int[] {1}, 2)]
        [InlineData(new int[] {2, 3}, 2)]
        public void Given_ArrayOfIntAndTarget_Expect_ThrowsArgumentException(int[] i, int t)
        {
            Assert.Throws<ArgumentException>(() => TwoSum.FindSum(i, t));
        }
    }
}
