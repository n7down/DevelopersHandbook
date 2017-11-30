using System;

namespace SelectionSort
{
    public class SelectionSort
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
                throw new ArgumentException("null or empty array");
            }
            if(d.Length == 1)
            {
                return d;
            }
            for(int i = 0; i < d.Length - 1; i++)
            {
                int min = d[i];
                int minIndex = i;
                for(int j = i; j < d.Length; j++)
                {
                    if(min < d[j])
                    {
                        min = d[j];
                        minIndex = j;
                    }
                }
                Swap(d, i, minIndex);
            }
            return d;
        }
    }
}
