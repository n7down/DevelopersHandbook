using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumProductSubarray
{
    public class Subarray
    {
        public static int MaximumProduct(int[] d)
        {
            if(d == null || d.Length == 0)
            {
                throw new ArgumentException("array is null or empty");
            }
            List<int> l = new List<int>();
            for(int i = 0; i < d.Length; i++)
            {
                for(int j = i; j < d.Length; j++)
                {
                    int product = 1;
                    for(int k = i; k <= j; k++)
                    {
                        product *= d[k];
                    }
                    l.Add(product);
                }
            }
            return l.Max();
        }
    }
}
