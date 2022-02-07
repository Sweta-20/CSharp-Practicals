using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IA
    {
        void method();
        void method1();
    }
    interface IB:IA
    {
        void method();
        void method2();
    }

    class InterfaceDemo:IB
    {
       void IA.method()//same method 
        {
            Console.WriteLine("same method from A..");
        }
        void IB.method()
        {
            Console.WriteLine("Same method from B..");
        }
        public void method1()
        {
            Console.WriteLine("method 1..");
        }
        public void method2()
        {
            Console.WriteLine("method 2..");
        }
        static void Main(string[] args)
        {
            InterfaceDemo obj = new InterfaceDemo();
            obj.method1();
            obj.method2();
            IA objIA = new InterfaceDemo();// calling same method name
            objIA.method();
            IB objIB = new InterfaceDemo();
            objIB.method();

            Console.ReadKey();
        }
    }
}
