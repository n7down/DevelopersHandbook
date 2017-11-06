using System;

namespace TwoSum
{
    public class TwoSum
    {
        public static int[] FindSum(int[] i, int t)
        {
            if(i.Length == 0 || i.Length == 1)
            {
                throw new ArgumentException("input does not contain valid arguments");
            }
            foreach(int a in i)
            {
                foreach(int b in i)
                {
                    if(a + b == t)
                    {
                        return new int[] {a, b};
                    }
                }
            }
            throw new ArgumentException("no two sum solution");
        }
    }
}
