﻿using System;

namespace Algorithms.V1.Interfaces
{
    internal abstract class Algorithm
    {
        public int Calculate(int first, int second)
        {
            throw  new NotImplementedException();
        }

        public int Calculate(int first, int second, out long milliseconds)
        {
            throw  new NotImplementedException();
        }
	
        protected abstract int Func(int first, int second);
    }
}