
using System;
using System.Collections.Generic;
using System.Text;

namespace zavd2
{
     class A
    {
        public A(B c)
        {
            c.Print();
        }
        public A(B c, B d)
        {
            
            
            Console.WriteLine($" {d}");
        }
        public A(B c, B d, B e)
        {
           
            Console.WriteLine($" {c}");
            Console.WriteLine($" {d}");
            Console.WriteLine($" {e}");
        }

    }
}