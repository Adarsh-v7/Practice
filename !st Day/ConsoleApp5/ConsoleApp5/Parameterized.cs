using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Parameterized
    {
        int x;
        public Parameterized(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called " + i);
     
        }
        public void Display()
        {
            Console.WriteLine("Value of x is " + x);
        }
        static void Main()
        {
            Parameterized Obj = new Parameterized(10);
            Parameterized Ob2 = new Parameterized(30);
            Obj.Display();
            Ob2.Display();
            Console.ReadLine();
        }
    }


}
