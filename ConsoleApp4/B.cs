using System;
using System.Collections.Generic;
using System.Text;

namespace zavd2
{
    internal abstract class B
    {
        
        
        public virtual void Print()
        {
            Console.WriteLine($"White color will change ");
           
        }

        public virtual int Sum(int a, int b)
        {
            return a + b;
        }

        public abstract double Math(int a, int b);
    }
}