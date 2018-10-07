using System;
using System.Collections.Generic;

namespace Fib
{
    public class Fib
    {
        public static List<int> BuildFib(int steps)
        {
            if(steps <= 1)
            {
                return new List<int> { 1 };
            }
            else if(steps == 2)
            {
                return new List<int> { 1, 1 };
            }
            else
            {
                List<int> r = new List<int> { 1, 1 };
                steps = steps - 2;
                for(int i = 0; i < steps; i++)
                {
                    var last = r[r.Count - 1];
                    var secondToLast = r[r.Count - 2];
                    r.Add(last + secondToLast);
                } 
                return r;  
            }
        }
    }
}
