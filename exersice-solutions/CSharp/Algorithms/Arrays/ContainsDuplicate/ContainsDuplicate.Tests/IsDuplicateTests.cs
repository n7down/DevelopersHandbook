using System;
using Xunit;

namespace ContainsDuplicate.Tests
{
    public class IsDuplicateTests
    {
        [Theory]
        [InlineData(new int[] {1, 1})]
        public void Given_ArrayOfInts_Expect_ReturnContainsDuplicateAsTrue(int[] i)
        {
            bool r = Duplicate.ContainsDuplicate(i);
            Assert.True(r);
        }

        [Theory]
        [InlineData(new int[] {1})]
        public void Given_ArrayOfInts_Expect_ReturnContainsDuplicateAsFalse(int[] i)
        {
            bool r = Duplicate.ContainsDuplicate(i);
            Assert.False(r);
        }

        [Theory]
        [InlineData(new int[] {})]
        public void Given_EmptyArray_Expect_ArgrumentException(int[] i)
        {
            Assert.Throws<ArgumentException>(() => Duplicate.ContainsDuplicate(i));
        }
    }
}
