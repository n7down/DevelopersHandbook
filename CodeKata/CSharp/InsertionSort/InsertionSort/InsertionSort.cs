using System;

namespace InsertionSort
{
    public class InsertionSort
    {
        public static void Swap(int[] d, int aIndex, int bIndex)
        {
            int tmp = d[aIndex];
            d[aIndex] = d[bIndex];
            d[bIndex] = tmp;
        }
        public static int[] Sort(int[] d)
        {
            if(d == null || d.Length == 0)
            {
                throw new ArgumentException("null or empty array");
            }
            int i = 1;
            while(i < d.Length)
            {
                int j = i;
                while(j > 0 && d[j-1] > d[j])
                {
                    Swap(d, j-1, j);
                    j--;
                }
                i++;
            }
            return d;
        }
    }
}
