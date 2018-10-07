using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Fib.Tests
{
    public class FibTests
    {
        private bool Equals(List<int> l0, List<int> l1)
        { 
            var l0Notl1 = l0.Except(l1).ToList();
            var l1Notl0 = l1.Except(l0).ToList();
            return !l0Notl1.Any() && !l1Notl0.Any();
        }

        [Fact]
        public void Given_1_Steps_BuildFib_Returns_Correct_Fib_List()
        {
            List<int> expected = new List<int> { 1 };
            List<int> actual = Fib.BuildFib(1);
            Assert.True(Equals(expected, actual));
        }

        [Fact]
        public void Given_2_Steps_BuildFib_Returns_Correct_Fib_List()
        {
            List<int> expected = new List<int> { 1, 1 };
            List<int> actual = Fib.BuildFib(2);
            Assert.True(Equals(expected, actual));
        }

        [Fact]
        public void Given_3_Steps_BuildFib_Returns_Correct_Fib_List()
        {
            List<int> expected = new List<int> { 1, 1, 2 };
            List<int> actual = Fib.BuildFib(3);
            Assert.True(Equals(expected, actual));
        }
        
        [Fact]
        public void Given_4_Steps_BuildFib_Returns_Correct_Fib_List()
        {
            List<int> expected = new List<int> { 1, 1, 2, 3 };
            List<int> actual = Fib.BuildFib(4);
            Assert.True(Equals(expected, actual));
        }

        [Fact]
        public void Given_5_Steps_BuildFib_Returns_Correct_Fib_List()
        {
            List<int> expected = new List<int> { 1, 1, 2, 3, 5 };
            List<int> actual = Fib.BuildFib(5);
            Assert.True(Equals(expected, actual));
        }
    }
}
