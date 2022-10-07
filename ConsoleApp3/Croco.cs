using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd1
{ 
    class Croco
    {
        protected int a = 10;       
        protected string c = "parametr";
        public virtual void Print()
        {
            Console.WriteLine($"Перший агрумент {a}");

           
            Console.WriteLine($"Третій агрумент {c}");
        }

        static void Main (string[] args)
        {
            Zebra zebra = new Zebra();
            zebra.Print();

        }


    }







}