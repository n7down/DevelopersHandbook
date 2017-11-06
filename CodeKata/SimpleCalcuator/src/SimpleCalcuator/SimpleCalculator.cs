using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCalculator;

namespace SimpleCalcuator
{
    public class SimpleCalculator
    {
        private readonly StringTokenizer _stringTokenizer;

        public SimpleCalculator(string s)
        {
            _stringTokenizer = new StringTokenizer(s);
        }

        public int Calculate()
        {
            int result = 0;
            result += int.Parse(_stringTokenizer.NextElement().ToString());
            while(_stringTokenizer.HasElements())
            {
                char op = _stringTokenizer.NextElement();
                int value = int.Parse(_stringTokenizer.NextElement().ToString());

                if(op == '+')
                {
                    result += value;
                }
                else if(op == '-')
                {
                    result -= value;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
        }
    }
}
