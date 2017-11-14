using System;

namespace MergeSort
{
    public class MergeSort
    {
        private static int[] Sort(int[] i, int l, int r)
        {
            if(i[r] > i[l])
            {
                int m = (l + r) / 2;
                int[] la = Sort(i, l, m);
                int[] ra = Sort(i, m + 1, r);
                int[] result = Merge(i, l, m, r);
                return result;
            }
            return new int[] {};
        }

        private static int[] Merge(int[] i, int l, int m, int r)
        {
            return new int[] {};
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
