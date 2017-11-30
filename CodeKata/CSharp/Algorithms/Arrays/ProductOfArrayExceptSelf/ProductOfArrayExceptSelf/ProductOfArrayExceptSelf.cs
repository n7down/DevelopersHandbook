using System;

namespace ProductOfArrayExceptSelf
{
    public class ProductOfArrayExceptSelf
    {
        public static int[] FindProductExceptSelf(int[] i)
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
                return new int[] { i[1], i[0] };
            }

            int[] r = new int[i.Length];
            for(int a = 0; a < i.Length; a++)
            {
                int sum = 1;
                for(int b = 0; b < i.Length; b++)
                {
                    if(a != b)
                    {
                        sum *= i[b];
                    }
                }
                r[a] = sum;
            }

            return r;
        }
    }
}
