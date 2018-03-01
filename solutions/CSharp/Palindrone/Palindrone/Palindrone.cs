using System;

namespace Palindrone
{
    public class Palindrone
    {
        private string _p;

        public Palindrone(string p)
        {
            _p = p;
        }

        public bool IsValid()
        {
            if(_p.Length == 1)
            {
                return true;
            }

            int size;
            if(_p.Length % 2 == 0)
            {
                size = _p.Length / 2;
            }
            else
            {
                size = (_p.Length - 1) / 2;
            }

            int start = 0;
            int end = _p.Length - 1;
            while(start != size + 1)
            {
                if(_p.Substring(start, 1) != _p.Substring(end, 1))
                {
                    return false;
                }
                start++;
                end--;
            }
            
            return true;
        }

        public static void Main(string[] args)
        {}
    }
}
