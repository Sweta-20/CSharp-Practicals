using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           internalDemo obj = new internalDemo();
            obj.setValue(10,20);
            obj.display3();
         //   obj.display2();obj.display1();
            Console.ReadKey();
        }
    }
}
