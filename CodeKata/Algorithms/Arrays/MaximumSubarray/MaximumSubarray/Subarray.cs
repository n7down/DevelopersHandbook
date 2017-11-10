using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumSubarray
{
    public class Subarray
    {
        public static bool EveryElementInArrayIsPositive(int[] i)
        {
            foreach(int a in i)
            {
                if(a < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EveryElementInArrayIsNegitive(int[] i)
        {
            foreach(int a in i)
            {
                if(a > 0)
                {
                    return false;
                }
            }
            return true;
        }

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

            // check if the array is positive
            if(EveryElementInArrayIsPositive(i))
            {
                // find the sum of the array
                List<int> pl = new List<int>();
                foreach(int a in i)
                {
                    pl.Add(a);
                }
                return pl.Sum();
            }
            // check if the array is negitive
            if(EveryElementInArrayIsNegitive(i))
            {
                // find the smallest number
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
