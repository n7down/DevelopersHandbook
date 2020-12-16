using System.Collections.Generic;
using System.Linq;

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
            int[,] r = new int[columnLength, rowLength];
            int column, row = 0;
            for(int oldColumn = columnLength - 1; oldColumn >= 0; oldColumn--)
            {
                column = 0;
                for(int oldRow = 0; oldRow < rowLength; oldRow++)
                {
                    r[row, column] = data[oldRow, oldColumn];
                    column++;
                }
                row++;
            }
            return r;
        }
    }
}