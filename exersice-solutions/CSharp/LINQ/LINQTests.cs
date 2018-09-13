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
            if (l0.Count != l1.Count)
            {
                return false;
            }
            for (int i = 0; i < l0.Count; i++)
            {
                if (l0[i].Number != l1[i].Number)
                {
                    return false;
                }
                if (l0[i].Square != l1[i].Square)
                {
                    return false;
                }
            }
            return true;
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

            public static bool Equals(List<NumberMultiplicationFrequency> n0, List<NumberMultiplicationFrequency> n1)
            {
                if (n0.Count != n1.Count)
                {
                    return false;
                }
                for (int i = 0; i < n0.Count; i++)
                {
                    if (n0[i].Number != n1[i].Number)
                    {
                        return false;
                    }
                    if (n0[i].Muliplication != n1[i].Muliplication)
                    {
                        return false;
                    }
                    if (n0[i].Frequency != n1[i].Frequency)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private class IdAndItem
        {
            public IdAndItem(int id, string i)
            {
                Id = id;
                Item = i;
            }

            public int Id { get; private set; }
            public string Item { get; private set; }
        }

        private class IdAndQuantity
        {
            public IdAndQuantity(int id, int q)
            {
                Id = id;
                Quantity = q;
            }

            public int Id { get; private set; }
            public int Quantity { get; private set; }
        }

        private class IdItemAndQuantity
        {
            public IdItemAndQuantity(int id, string item, int q)
            {
                Id = id;
                Item = item;
                Quantity = q;
            }

            public IdItemAndQuantity(int id, string item)
            {
                Id = id;
                Item = item;
                Quantity = 0;
            }

            public int Id { get; private set; }
            public string Item { get; private set; }
            public int? Quantity { get; private set; }
        }

        private class IdItemAndQuantityComparer : IEqualityComparer<IdItemAndQuantity>
        {
            public bool Equals(IdItemAndQuantity i0, IdItemAndQuantity i1)
            {
                if (i0.Id != i1.Id)
                {
                    return false;
                }
                if (i0.Item != i1.Item)
                {
                    return false;
                }
                if (i0.Quantity != i1.Quantity)
                {
                    return false;
                }
                return true;
            }

            public int GetHashCode(IdItemAndQuantity obj)
            {
                return obj.GetHashCode();
            }
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

        [Fact]
        public void Given_List_Of_Numbers_Display_Numbers_Multiplication_Of_Numbers_With_Frequency_Of_A_Number()
        {
            int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };            
            List<NumberMultiplicationFrequency> actual = numbers.GroupBy(n => n).Select(n => new NumberMultiplicationFrequency(n.Key, n.Key * n.Count(), n.Count())).ToList();

            List<NumberMultiplicationFrequency> expected = new List<NumberMultiplicationFrequency> {
                { new NumberMultiplicationFrequency(5, 15, 3) },
                { new NumberMultiplicationFrequency(1, 1, 1) },
                { new NumberMultiplicationFrequency(9, 9, 1) },
                { new NumberMultiplicationFrequency(2, 4, 2) },
                { new NumberMultiplicationFrequency(3, 6, 2) }, 
                { new NumberMultiplicationFrequency(7, 14, 2) },
                { new NumberMultiplicationFrequency(4, 8, 2) },
                { new NumberMultiplicationFrequency(6, 12, 2) },
                { new NumberMultiplicationFrequency(8, 8, 1) }
            };

            Assert.True(NumberMultiplicationFrequency.Equals(actual, expected));
        }

        [Fact]
        public void Given_An_Array_Of_Strings_Find_The_Strings_That_Start_And_End_With_A_Specific_Character()
        {
            List<string> input = new List<string> {
                "ROME",
                "LONDON",
                "NAIROBI",
                "CALIFORNIA",
                "ZURICH",
                "NEW DELHI",
                "AMSTERDAM",
                "ABU DHABI",
                "PARIS"
            };

            List<string> actual = input.Where(s => s.StartsWith("A", StringComparison.Ordinal)).Where(s => s.EndsWith("M", StringComparison.Ordinal)).Select(s => s).ToList();
            string expected = "AMSTERDAM";
            var isEquivalent = actual[0].Equals(expected);
            Assert.True(isEquivalent);
        }

        [Fact]
        public void Given_List_Display_Numbers_Greater_Then_80()
        {
            int[] input = { 55, 200, 740, 76, 230, 482, 95 };
            var actual = input.Where(n => n > 80).Select(n => n).ToArray();
            int[] expected = { 200, 740, 230, 482, 95 };
            Assert.True(actual.SequenceEqual(expected));
        }

        [Fact]
        public void Given_A_List_Of_Numbers_Get_The_Top_Three_Numbers()
        {
            int[] numbers = { 5, 7, 13, 24, 6, 9, 8, 7 };
            int[] actual = numbers.OrderByDescending(n => n).Select(n => n).Take(3).ToArray();
            int[] expected = { 24, 13, 9 };
            Assert.True(actual.SequenceEqual(expected));
        }

        [Fact]
        public void Given_A_List_Of_Words_Find_The_Words_That_Are_Upper_Case()
        {
            string s = "this IS a STRING";
            string[] actual = s.Split(" ").Where(c => c.All(char.IsUpper)).ToArray();
            string[] expected = { "IS", "STRING" };
            Assert.True(actual.SequenceEqual(expected));
        }

        [Fact]
        public void Given_Array_Of_Strings_Output_An_Concated_String_Of_The_Array()
        {
            string[] input = { "cat", "dog", "rat" };
            string actual = String.Join(", ", input.Select(s => s.ToString()).ToArray());
            string expected = "cat, dog, rat";
            var isEquals = actual.Equals(expected);
            Assert.True(isEquals);
        }

        [Fact]
        public void Given_A_List_Of_Strings_Order_Lengths_In_Assending_Order()
        {
            string[] input = {                
                "CALIFORNIA",
                "NAIROBI", 
                "PARIS", 
                "LONDON", 
                "ZURICH", 
                "ABU DHABI", 
                "AMSTERDAM", 
                "NEW DELHI", 
                "ROME"
            };

            string[] actual = input.OrderBy(s => s.Length).Select(s => s).ToArray();

            string[] expected = {
                "ROME", 
                "PARIS", 
                "LONDON", 
                "ZURICH", 
                "NAIROBI", 
                "ABU DHABI", 
                "AMSTERDAM", 
                "NEW DELHI", 
                "CALIFORNIA"
            };

            Assert.True(actual.SequenceEqual(expected));
        }

        [Fact]
        public void Given_Two_Lists_Join_Into_One_List()
        {
            List<IdAndItem> idAndItem = new List<IdAndItem> {
                new IdAndItem(1, "Biscuit"),
                new IdAndItem(2, "Chocolate"),
                new IdAndItem(3, "Butter"),
                new IdAndItem(4, "Brade")
            };

            List<IdAndQuantity> idAndQuantity = new List<IdAndQuantity> {
                new IdAndQuantity(1, 458),
                new IdAndQuantity(2, 650),
                new IdAndQuantity(3, 800),
                new IdAndQuantity(3, 900),
                new IdAndQuantity(3, 900),
                new IdAndQuantity(4, 700),
                new IdAndQuantity(4, 650)
            };

            List<IdItemAndQuantity> actual = idAndItem.Join(idAndQuantity, i => i.Id, j => j.Id, (i, j) => new IdItemAndQuantity(i.Id, i.Item, j.Quantity)).ToList();

            List<IdItemAndQuantity> expected = new List<IdItemAndQuantity> {
                new IdItemAndQuantity(1, "Biscuit", 458),
                new IdItemAndQuantity(2, "Chocolate", 650),
                new IdItemAndQuantity(3, "Butter", 800),
                new IdItemAndQuantity(3, "Butter", 900),
                new IdItemAndQuantity(3, "Butter", 900),
                new IdItemAndQuantity(4, "Brade", 700),
                new IdItemAndQuantity(4, "Brade", 650)
            };
            var isEqual = actual.SequenceEqual(expected, new IdItemAndQuantityComparer());
            Assert.True(isEqual);
        }

        [Fact]
        public void Given_Two_List_Left_Join_Into_One_List()
        {
            List<IdAndItem> idAndItem = new List<IdAndItem> {
                new IdAndItem(1, "Biscuit"),
                new IdAndItem(2, "Chocolate"),
                new IdAndItem(3, "Butter"),
                new IdAndItem(4, "Brade"),
                new IdAndItem(5, "Honey")
            };

            List<IdAndQuantity> idAndQuantity = new List<IdAndQuantity> {
                new IdAndQuantity(1, 458),
                new IdAndQuantity(2, 650),
                new IdAndQuantity(3, 800),
                new IdAndQuantity(3, 900),
                new IdAndQuantity(3, 900),
                new IdAndQuantity(4, 700),
                new IdAndQuantity(4, 650)
            };

            List<IdItemAndQuantity> expected = new List<IdItemAndQuantity> {
                new IdItemAndQuantity(1, "Biscuit", 458),
                new IdItemAndQuantity(2, "Chocolate", 650),
                new IdItemAndQuantity(3, "Butter", 800),
                new IdItemAndQuantity(3, "Butter", 900),
                new IdItemAndQuantity(3, "Butter", 900),
                new IdItemAndQuantity(4, "Brade", 700),
                new IdItemAndQuantity(4, "Brade", 650),
                new IdItemAndQuantity(5, "Honey", 0)
            };

            var actual = idAndItem.GroupJoin(idAndQuantity, i => i.Id, j => j.Id, (ii, jj) => new { ii, jj = jj.DefaultIfEmpty() }).SelectMany(z => z.jj.Select(m => new { Id = z.ii.Id, Item = z.ii.Item, Quantity = m.Quantity }));
            List<IdItemAndQuantity> actualList = new List<IdItemAndQuantity>();
            // TODO: i am not sure how to do this
            //foreach(var a in actual)
            //{
            //    actualList.Add(new IdItemAndQuantity(a.Id, a.Item, a.Quantity));
            //}
            var isEqual = expected.SequenceEqual(actualList, new IdItemAndQuantityComparer());
            Assert.True(isEqual);
        }

        [Fact]
        public void Aggregate_Data()
        {
            List<IdAndQuantity> idAndQuantity = new List<IdAndQuantity> {
                new IdAndQuantity(1, 458),
                new IdAndQuantity(2, 650),
                new IdAndQuantity(3, 800),
                new IdAndQuantity(3, 900),
                new IdAndQuantity(3, 900),
                new IdAndQuantity(4, 700),
                new IdAndQuantity(4, 650)
            };

            var actual = from i in idAndQuantity
                        group i by i.Id into gr
                        select new
                        {
                            Id = gr.Key,
                            Max = gr.Max(g => g.Id),
                            Min = gr.Min(g => g.Id)
                        };
            // TODO: i dont know how to test this
            Assert.True(false);
        }
    }
}
