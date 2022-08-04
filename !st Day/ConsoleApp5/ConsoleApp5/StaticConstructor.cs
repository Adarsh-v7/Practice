using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor is executed ");
        }
        static void Main()
        {
            Console.WriteLine("main Method is executed");
        }
    }

}
