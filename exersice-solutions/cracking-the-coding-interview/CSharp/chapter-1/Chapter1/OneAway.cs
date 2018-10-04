using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    public static class OneAway
    {
        public static bool CheckOneAway(string s, string t)
        {
            var sa = s.ToCharArray();
            var ta = t.ToCharArray();
            var d = sa.Except(ta).ToArray();
            return d.Length == 1;
        }
    }
}