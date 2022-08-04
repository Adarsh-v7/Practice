using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Access
    {
        public void Test1()
        {
            Console.WriteLine("Public Method ");
        }
        private void Test2()
        {
            Console.WriteLine("private Method");
        }
        protected void Test3()
        {
            Console.WriteLine("protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected internal Method");
        }
        internal void Test5()
        {
            Console.WriteLine("Internal Method");
        }
        static void Main()
        {
            Access P = new Access();
            P.Test1();P.Test2();P.Test3();P.Test4();P.Test5();
        }
    }
}
