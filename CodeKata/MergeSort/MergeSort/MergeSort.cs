using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class MergeSort
    {
        private static int[] Sort(int[] i, int l, int r)
        {
            // TODO: need to check if this is even or odd?
            int m = (l + r) / 2;
            
            // if m is even
            if(m % 2 == 0)
            {}

            // if m is odd
            else
            {}
            
            int[] result;
            if(i[r] > i[l])
            {
                int[] la = Sort(i, l, m);
                int[] ra = Sort(i, m + 1, r);
                result = Merge(la, m, ra);
            }
            else
            {
                int[] la = Sort(i, r, m);
                int[] ra = Sort(i, m + 1, l);
                result = Merge(ra, m, la);
            }
            return result;
        }

        private static int[] Merge(int[] l, int m, int[] r)
        {
            List<int> result = new List<int>();
            foreach(int a in l)
            {
                result.Add(a);
            }
            result.Add(m);
            foreach(int b in r)
            {
                result.Add(b);
            }
            return result.ToArray();
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
