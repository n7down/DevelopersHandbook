﻿using System;

namespace SelectionSort
{
    public class SelectionSort
    {
        public static int[] Sort(int[] d)
        {
            if(d == null || d.Length == 0)
            {
                throw new ArgumentException("null or empty array");
            }
            if(d.Length == 1)
            {
                return d;
            }
            for(int i = 0; i < d.Length - 1; i++)
            {
                int min = d[i];
                for(int j = i; j < d.Length; j++)
                {
                    // TODO
                }
            }
            return new int[] {};
        }
    }
}
