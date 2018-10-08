using System.Collections.Generic;

namespace Chapter1
{
    public static class RotateMatrix
    {
        public static int[,] Rotate90Degrees(int[,] data)
        {
            int rowLength = data.GetLength(0);
            int columnLength = data.GetLength(1);
            if(rowLength == 1 && columnLength == 1)
            {
                return data;
            }
            Dictionary<int, string> t = new Dictionary<int, string>();
            for(int i = 0; i < rowLength; i++)
            {
                for(int j = 0; j < columnLength; j++)
                {
                    var d = data[i, j];
                }
            }
            return new int[,] {};
        }
    }
}