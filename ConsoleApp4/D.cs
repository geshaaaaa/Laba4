
using System;
using System.Collections.Generic;
using System.Text;

namespace zavd2
{
     class D : B
    {
        public override void Print()
        {
            Console.WriteLine($"White color will be changed ");
            Console.ForegroundColor = ConsoleColor.Blue;
            
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a * b;
        }
    }
}