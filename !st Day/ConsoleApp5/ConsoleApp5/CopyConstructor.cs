using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;

        }
        public CopyConstructor(CopyConstructor Obj)
        {
            x = Obj.x;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is " + x);
        }
        static void Main()
        {

            CopyConstructor Obj = new CopyConstructor(10);
            CopyConstructor Obj1 = new CopyConstructor(Obj);

            Obj.Display();
            Console.ReadLine();
        }
    }
}
