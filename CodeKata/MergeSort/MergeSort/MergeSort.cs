using System;

namespace MergeSort
{
    public class MergeSort
    {
        public static int[] Sort(int[] i)
        {
            if(i == null || i.Length == 0)
            {
                throw new ArgumentException("array is null or empty");
            }
            if(i.Length == 1)
            {
                return i;
            }
            return new int[] {};
        }
    }
}
