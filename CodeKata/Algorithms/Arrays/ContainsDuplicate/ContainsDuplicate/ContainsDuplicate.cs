using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    public class Duplicate
    {
        public static bool ContainsDuplicate(int[] a)
        {
            if(a.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            if(a.Length == 1)
            {
                return false;
            }
            List<int> l = new List<int>();
            foreach(int i in a)
            {
                if(!l.Contains(i))
                {
                    l.Add(i);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }   
    }
}
