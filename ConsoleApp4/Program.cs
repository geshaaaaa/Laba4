
using System;

namespace zavd2
{
    class Program
    {

        static void Main(string[] args)
        {
            C c = new C();
            D d = new D();
            E e = new E();
            A a = new A(c, d, e);
            d.Print();
            double func = d.Math(3, 9);
            Console.WriteLine(func);
        }
    }
}