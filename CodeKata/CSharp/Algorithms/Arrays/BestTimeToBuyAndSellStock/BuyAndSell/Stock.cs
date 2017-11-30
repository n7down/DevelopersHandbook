using System;

namespace BuyAndSell
{
    public class Stock
    {
        public static int MaxProfit(int[] a)
        {
            if(a == null || a.Length == 0)
            {
                throw new ArgumentException("array is null or empty");
            }
            return -1;
        }
    }
}
