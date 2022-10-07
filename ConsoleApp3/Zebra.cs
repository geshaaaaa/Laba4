using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd1
{
    class Zebra : Croco
    {
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Перший агрумент: {a} \n {a.GetType}");          
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Третій агрумент: {c} \n {c.GetType}");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
