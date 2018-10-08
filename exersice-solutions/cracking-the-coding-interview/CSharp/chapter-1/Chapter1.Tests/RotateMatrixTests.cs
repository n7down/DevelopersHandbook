using Xunit;

namespace Chapter1.Tests
{
    public class RotateMatrixTests
    {
        [Fact]
        public void Given_A_1x1_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            int[,] data = new int[,] { { 1 } };
            int[,] expected = new int[,] { { 1 } };
        }

        [Fact]
        public void Given_A_2x1_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            int[,] data = new int[,] { { 1, 2 } };
            int[,] expected = new int[,] { { 1 }, 
                                           { 2 } };
        }

        [Fact]
        public void Given_A_2x2_Matrix_Rotate90Degrees_Will_Return_A_Matrix_90_Degrees()
        {
            int[,] data = new int[,] { { 1, 2 }, 
                                       { 3, 4 } };
            int[,] expected = new int[,] { { 3, 1 }, 
                                           { 4, 2 } };
        }
    }
}