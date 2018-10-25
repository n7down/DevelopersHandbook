using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Permutation.Tests
{
    public class PermutationTests
    {
        private bool CheckPermentations(int[,] permentations, int[,] expectedPermentations)
        {
            List<string> p = new List<string>();
            List<string> ep = new List<string>();
            
            for (int i = 0; i < permentations.GetLength(0); i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int j = 0; j < permentations.GetLength(1); j++)
                {
                    string s = permentations[i, j].ToString();
                    stringBuilder.Append(s);
                }
                p.Add(stringBuilder.ToString());
            }
            
            for (int i = 0; i < expectedPermentations.GetLength(0); i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int j = 0; j < expectedPermentations.GetLength(1); j++)
                {
                    string s = expectedPermentations[i, j].ToString();
                    stringBuilder.Append(s);
                }
                ep.Add(stringBuilder.ToString());
            }

            if(p.Count != ep.Count)
            {
                return false;
            }

            foreach(string pp in p)
            {
                if(!ep.Contains(pp))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckPermentations(List<string> s0, List<string> s1)
        {
            var zeroExceptOne = s0.Except(s1).ToList();
            var oneExceptZero = s1.Except(s0).ToList();
            return !zeroExceptOne.Any() && !oneExceptZero.Any();
        }

        [Fact]
        public void Test_Two_Permentations()
        {
            int[] c = new int[] {2, 1};
            int[,] expectedPermentations = new int[,] {{1, 2}, {2, 1}};
            int[,] permentations = Permutation.GetPermutations(c);
            Assert.True(CheckPermentations(permentations, expectedPermentations));
        }

        [Fact]
        public void Test_Two_String_Permentations()
        {
            string s = "ab";
            List<string> expectedPermentations = new List<string> { "ab", "ba" };
            List<string> permentations = Permutation.GetPermutations(s);
            Assert.True(CheckPermentations(permentations, expectedPermentations));
        }

        
        [Fact]
        public void Test_Three_String_Permentations()
        {
            string s = "abc";
            List<string> expectedPermentations = new List<string> { "abc", "acb", "bac", "bca", "cba", "cab" };
            List<string> permentations = Permutation.GetPermutations(s);
            Assert.True(CheckPermentations(permentations, expectedPermentations));
        }
    }
}
