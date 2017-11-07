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
            int l = i.Length;

            return new int[] { 0 };
        }
    }
}
