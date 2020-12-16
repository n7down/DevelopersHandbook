using System.Linq;
using Xunit;

namespace Chapter1.Tests
{
    public class RotateMatrixTests
    {
        private bool Equals(int[,] d, int[,] e)
        {
            return d.Rank == e.Rank &&
                Enumerable.Range(0,d.Rank).All(dimension => d.GetLength(dimension) == e.GetLength(dimension)) &&
                d.Cast<int>().SequenceEqual(e.Cast<int>());
        }

        [Fact]
        public void Given_A_1x1_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            int[,] data = new int[,] { { 1 } };
            int[,] expected = new int[,] { { 1 } };
            int[,] actual = RotateMatrix.Rotate90Degrees(data);
            Assert.True(Equals(expected, actual));
        }

        [Fact]
        public void Given_A_2x1_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            /*
            [0][0] = 1
            [0][1] = 2
            to
            [0][0] = 2
            [1][0] = 1
             */
            int[,] data = new int[,] { { 1, 2 } };
            int[,] expected = new int[,] { { 2 }, 
                                           { 1 } };
            int[,] actual = RotateMatrix.Rotate90Degrees(data);
            Assert.True(Equals(expected, actual));
        }

        [Fact]
        public void Given_A_2x2_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            /*
            [0][0] = 1
            [0][1] = 2
            [1][0] = 3
            [1][1] = 4
            to
            [0][0] = 2
            [0][1] = 4
            [1][0] = 1
            [1][1] = 3
             */
            int[,] data = new int[,] { { 1, 2 }, 
                                       { 3, 4 } };
            int[,] expected = new int[,] { { 2, 4 }, 
                                           { 1, 3 } };
            int[,] actual = RotateMatrix.Rotate90Degrees(data);
            Assert.True(Equals(expected, actual));
        }

        [Fact]
        public void Given_A_3x2_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            /*
            [0][0] = 1
            [0][1] = 2
            [0][2] = 3
            [1][0] = 4
            [1][1] = 5
            [1][2] = 6
            to
            [0][0] = 3
            [0][1] = 6
            [1][0] = 2
            [1][1] = 5
            [2][0] = 1
            [2][1] = 4
             */
            int[,] data = new int[,] { { 1, 2, 3 }, 
                                       { 4, 5, 6 } };
            int[,] expected = new int[,] { { 3, 6 }, 
                                           { 2, 5 },
                                           { 1, 4 } };
            int[,] actual = RotateMatrix.Rotate90Degrees(data);
            Assert.True(Equals(expected, actual));
        }
    }
}