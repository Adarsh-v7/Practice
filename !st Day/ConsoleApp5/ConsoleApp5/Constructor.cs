using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Constructor is called");
        }
        static void Main()
        {
            Constructor Obj1 = new Constructor();
            Console.ReadLine();
        }
    }
}
