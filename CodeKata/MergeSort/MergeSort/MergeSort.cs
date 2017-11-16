using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class MergeSort
    {
        private static int[] Sort(int[] i)
        {
            int len = i.Length;
            if(len < 2)
            {
                return i;
            }
            int mid = len / 2;
            int[] left = new int[mid];
            int[] right = new int [len - mid];
            for(int j = 0; j < mid; j++)
            {
                left[j] = i[j];
            }
            for(int k = mid; k < len; k++)
            {
                right[k - mid] = i[k];
            }
            int[] leftSorted = Sort(left);
            int[] rightSorted = Sort(right);
            return Merge(leftSorted, rightSorted);
        }

        private static int[] Merge(int[] l, int[] r)
        {
            int[] res = new int[l.Length + r.Length];
            int i = 0, j = 0, k = 0;
            while(i < l.Length && j < r.Length)
            {
                if(l[i] < r[j])
                {
                    res[k] = l[i];
                    i++;
                }
                else
                {
                    res[k] = r[j];
                    j++;
                }
                k++;
            }
            while(i < l.Length)
            {
                res[k] = l[i];
                i++;
                k++;
            }
            while(j < r.Length)
            {
                res[k] = r[j];
                j++;
                k++;
            }
            return res;
        }

        public static int[] Run(int[] i)
        {
            if(i == null || i.Length == 0)
            {
                throw new ArgumentException("array is null or empty");
            }
            return Sort(i);
        }
    }
}
