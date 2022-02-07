using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface A
    {
      void method();
    }
    class a:A
    {
        public void method()
        {
            Console.WriteLine("Parent A");
        }
    }
    interface B
    {
        void method2();
    }
    class b : B
    {
        public void method2()
        {
            Console.WriteLine("Parent B");
        }
    }

    class c : A, B
    {
        a objA = new a();
        b objB = new b();

        public void method()
        {
            objA.method();
            Console.WriteLine("Child class C");
        }
        public void method2()
        {
            objB.method2();
            Console.WriteLine("Child class C");
        }

         static void Main(string[] args)
        {
            c objC = new c();
            objC.method();
            objC.method2();
            Console.ReadKey();
        }
    }
}
