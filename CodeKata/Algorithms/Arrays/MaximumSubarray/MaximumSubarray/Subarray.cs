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
                return i.ToList().Sum();
            }
            // check if the array is negitive
            if(EveryElementInArrayIsNegitive(i))
            {
                // find the smallest number
                List<int> pl = i.OrderByDescending(p => p).ToList();
                return pl[0];
            }
            
            // list of contiguous subarray sums
            List<int> css = new List<int>();

            int begin = 0;
            int end = 0;

            // find all of the contiguous subarray sums
            while(begin < i.Length)
            {
                
            }
            return css.Max();
        }
    }
}
