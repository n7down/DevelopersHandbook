using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumSubarray
{
    public class Subarray
    {
        public static int FindLargestSumOfContiguousSubarray(int[] i)
        {
            if(i == null || i.Length == 0)
            {
                throw new ArgumentException("array is null or empty");
            }
            if(i.Length == 1)
            {
                return i[0];
            }

            List<int> l = new List<int>();
            foreach(int a in i)
            {
                if(l.Count == 0)
                {
                    l.Add(a);
                }
                else
                {
                    int lastElement = l[l.Count - 1];
                    if(lastElement >= a)
                    {
                        l.Add(a);
                    }
                }
            }
            return l.Sum();
        }
    }
}
