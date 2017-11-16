using System;

namespace QuickSort
{
    public class QuickSort
    {
        private static int[] Sort(int[] i, int s, int e)
        {
            if(s < e)
            {
                int p = Partition(i, s, e);
                Sort(i, s, p-1);
                Sort(i, p+1, e);
            }
            return i;
        }

        private static int Partition(int[] i, int s, int e)
        {
            int p = i[e];
            int pIndex = s;
            int tmp = 0;
            for(int j = s; j < e-1; j++)
            {
                if(i[j] <= p)
                {
                    tmp = i[j];
                    i[j] = i[pIndex];
                    i[pIndex] = tmp;
                    pIndex++;
                }
            }
            tmp = i[e];
            i[e] = i[pIndex];
            i[pIndex] = tmp;
            return pIndex;
        }

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
            return Sort(i, 0, i.Length - 1);
        }
    }
}
