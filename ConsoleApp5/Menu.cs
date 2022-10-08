using System;
using System.Collections.Generic;
using System.Text;

namespace zavd3
{
    class Menu
    {

        private int a;
        private int b;
        private string s = "";
        private string t = "";
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public string S
        {
            get { return s; }
            set { s = value; }
        }
        public string T
        {
            get { return t; }
            set { t = value; }
        }
        public Menu(string s, string t)
        {
            s = S;
            t = T;
        }
        public Menu(int a, int b)
        {
            a = A;
            b = B;
        }
        static void Main(string[] args)
        {
            Position position = new Position("Морозиво", "Солодощі");
            Console.WriteLine("Ціна та грами:");
            PricenWeight pricenWeight = new PricenWeight(210, 440);
            Console.WriteLine($"Позиція:{position.S} Розділ:{position.T} Ціна:{pricenWeight.A} Грами:{pricenWeight.B}");

        }



    }




}