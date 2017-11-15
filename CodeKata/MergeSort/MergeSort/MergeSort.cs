using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class MergeSort
    {
        private static int[] Sort(int[] i, int l, int r)
        {
            int[] result;

            // if m is even
            if(i.Length % 2 == 0)
            {
                result = new int[] {};
            }

            // if m is odd
            else
            {
                int middleIndex = (l + r) / 2;
                int m = i[middleIndex];
                int[] ls = new int[] {};
                int[] rs = new int[] {};
                result = Merge(ls, m, rs);
            }
            
            // int[] result;
            // if(i[r] > i[l])
            // {
            //     int[] ls = Sort(i, l, m);
            //     int[] rs = Sort(i, m + 1, r);
            //     result = Merge(ls, m, rs);
            // }
            // else
            // {
            //     int[] ls = Sort(i, r, m);
            //     int[] rs = Sort(i, m + 1, l);
            //     result = Merge(rs, m, ls);
            // }
            // return result;

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
            if(i.Length == 2)
            {
                int[] r;
                if(i[0] < i[1])
                {
                    r = new int[] { i[0], i[1] };
                }
                else
                {
                    r = new int[] { i[1], i[0] };
                }
                return r;
            }
            return Sort(i, 0, i.Length - 1);
        }
    }
}
