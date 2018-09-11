using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using System.Text;

namespace LINQ
{
    public class LINQTests
    {
        public class NumberAndSquare
        {
            public NumberAndSquare(int n, int s)
            {
                Number = n;
                Square = s;
            }
            public int Number { get; private set; }
            public int Square { get; private set; }
        }

        private string PrintList(List<int> input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[ ");
            foreach(int i in input)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }

        private bool Compare(List<int> l0, List<int> l1)
        {
            var firstNotSecond = l0.Except(l1).ToList();
            var secondNotFirst = l1.Except(l0).ToList();
            return !firstNotSecond.Any() && !secondNotFirst.Any();
        }

        private string PrintList(List<NumberAndSquare> input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[ ");
            foreach(NumberAndSquare n in input)
            {
                stringBuilder.Append("number: ");
                stringBuilder.Append(n.Number);
                stringBuilder.Append(" square: ");
                stringBuilder.Append(n.Square);
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }

        private bool Compare(List<NumberAndSquare> l0, List<NumberAndSquare> l1)
        {
            if(l0.Count != l1.Count)
            {
                return false;
            }
            for(int i = 0; i < l0.Count; i++)
            {
                if(l0[i].Number != l0[i].Number)
                {
                    return false;
                }
                if(l1[i].Square != l1[i].Square)
                {
                    return false;
                }
            }
            return true;
        }

        [Fact]
        public void Output_Numbers_Where_Numbers_Are_Even()
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> actual = numbers.Where(n => n % 2 == 0).Select(n => n).ToList();
            List<int> expected = new List<int> { 0, 2, 4, 6, 8 };
            Assert.True(Compare(actual, expected), userMessage: $"expected: " + PrintList(expected) + " actual: " + PrintList(actual));
        }

        [Fact]
        public void Output_List_Of_Numbers_Using_Two_Where_Conditions()
        {
            List<int> number = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            List<int> actual = number.Where(n => n > 0).Where(n => n < 11).Select(n => n).ToList();
            List<int> expected = new List<int> { 1, 3, 6, 9, 10 };
            Assert.True(Compare(actual, expected), userMessage: $"expected: " + PrintList(expected) + " actual: " + PrintList(actual));
        }
        
        [Fact]
        public void Output_List_Of_Number_And_Its_Square_Given_A_List_Of_Numbers()
        {
            List<int> number = new List<int> { 9, 8, 6, 5 };
            List<NumberAndSquare> actual = number.Select(n => new NumberAndSquare(n, n * n)).ToList();
            List<NumberAndSquare> expected = new List<NumberAndSquare> { new NumberAndSquare(9, 81), new NumberAndSquare(8, 64), new NumberAndSquare(6, 36), new NumberAndSquare(5, 25) };
            Assert.True(Compare(actual, expected), userMessage: $"expected: " + PrintList(expected) + " actual: " + PrintList(actual));

        }

        [Fact]
        public void Output_List_Of_Number_And_Frequency_Of_A_Given_Array()
        {
            List<int> number = new List<int> { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var actual = number.GroupBy(n => n);
            foreach(var a in actual)
            {
                var actualCount = a.Count();
                int expectedCount = -1;
                switch(a.Key)
                {
                    case 5:
                        expectedCount = 3;
                        break;
                    case 9:
                        expectedCount = 2;
                        break;
                    case 1:
                        expectedCount = 1;
                        break;
                    case 2:
                        expectedCount = 2;
                        break;
                    case 7:
                        expectedCount = 3;
                        break;
                    case 6:
                        expectedCount = 3;
                        break;
                    case 3:
                        expectedCount = 2;
                        break;
                    case 8:
                        expectedCount = 1;
                        break;
                    case 4:
                        expectedCount = 1;
                        break;
                    default:
                        break;
                }
                Assert.True(actualCount == expectedCount, userMessage: $"expected: " + expectedCount + " actual: " + actualCount);
            }
        }

        [Fact]
        public void Output_List_Of_Characters_And_Their_Frequency_In_A_String()
        {
            string input = "apple";
            var actual = input.ToArray().GroupBy(l => l);
            var expected = new Dictionary<char, int>() { 
                { 'a', 1 },
                { 'p', 2 },
                { 'l', 1 },
                { 'e', 1 }
            };
            foreach(var a in actual)
            {
                var value = expected[a.Key];
                Assert.True(a.Count() == value);
            }
        }

        public class NumberMultiplicationFrequency
        {
            public NumberMultiplicationFrequency(int n, int m, int f)
            {
                Number = n;
                Muliplication = m;
                Frequency = f;
            }
            public int Number { get; private set; }
            public int Muliplication { get; private set; }
            public int Frequency { get; private set; }

            public bool Equals(NumberMultiplicationFrequency n)
            {
                if(Number != n.Number)
                {
                    return false;
                }
                if(Muliplication != n.Muliplication)
                {
                    return false;
                }
                if(Frequency != n.Frequency)
                {
                    return false;
                }
                return true;
            }
        }

        [Fact]
        public void Given_List_Of_Numbers_Display_Numbers_Multiplication_Of_Numbers_With_Frequency_Of_A_Number()
        {
            int[] numbers = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };            
            List<NumberMultiplicationFrequency> actual = numbers.GroupBy(n => n).Select(n => new NumberMultiplicationFrequency(n.Key, n.Key * n.Count(), n.Count())).ToList();

            List<NumberMultiplicationFrequency> expected = new List<NumberMultiplicationFrequency> {
                { new NumberMultiplicationFrequency(5, 15, 3) },
                { new NumberMultiplicationFrequency(1, 1, 1) },
                { new NumberMultiplicationFrequency(9, 9, 1) },
                { new NumberMultiplicationFrequency(2, 4, 2) }
            };
        }
    }
}
