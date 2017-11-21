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
            bool swapping = true;
            int i = 0;
            while(swapping)
            {
                if(d[i] > d[i+1])
                {
                    Swap(d, i, i+1);
                }
                swapping = false;
            }
            return d;
        }
    }
}
