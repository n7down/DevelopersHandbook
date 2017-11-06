
using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    public class StringTokenizer
    {
        private char[] tokens;
        private int index;

        public StringTokenizer(string strdata)
        {
            tokens = strdata.ToCharArray();
        }

        public bool HasElements()
        {
            return (index < (tokens.Length));
        }

        public int Length
        {
            get
            {
                return tokens.Length - index;
            }
        }

        public char NextElement()
        {
            if (index < tokens.Length)
            {
                return tokens[index++];
            }
            else
            {
                return '\0';
            }
        }
    }
}