using System;

namespace BubbleSort
{
    public class BubbleSort
    {
        private static void Swap(int[] d, int a, int b)
        {
            int tmp = d[a];
            d[a] = d[b];
            d[b] = tmp;
        }

        public static int[] Sort(int[] d)
        {
            if(d == null || d.Length == 0)
            {
                throw new ArgumentException("array is null or empty");
            }
            if(d.Length == 1)
            {
                return d;
            }
            for(int i = 0; i < d.Length - 1; i++)
            {
                for(int j = 0; j < d.Length - i - 1; j++)
                {
                    if(d[j] > d[j + 1])
                    {
                        Swap(d, j, j + 1);
                    }
                }
            }
            return d;
        }
    }
}
