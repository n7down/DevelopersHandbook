using System;
using System.Collections;

namespace Queue
{
    public class Queue
    {
        Stack s0;
        Stack s1;

        private void MoveElements()
        {
            if(s1.Count == 0)
            {
                while(s0.Count != 0)
                {
                    char c = (char) s0.Pop();
                    s1.Push(c);
                }
            }
        }

        public Queue()
        {
            s0 = new Stack();
            s1 = new Stack();
        }

        public void Enqueue(char c)
        {
            s0.Push(c);
        }

        public char Dequeue()
        {
            MoveElements();
            if(s1.Count != 0)
            {
                return (char) s1.Pop();
            }
            return '\0';
        }

        public char Peek()
        {
            MoveElements();
            if(s1.Count != 0)
            {
                return (char) s1.Peek();
            }
            return '\0';
        }

        public bool Contains(char c)
        {
            if(s0.Contains(c))
            {
                return true;
            }
            if(s1.Contains(c))
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            return s0.Count + s1.Count;
        }
    }
}
