using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate int DelegateDemo(int n);
    class Delegates
    {
        private static int num = 10;

        public static int add(int n)
        {
            num += n;
            return num;
        }
        public static int mul(int n)
        {
            num *= n;
            return num;
        }

        public static int print()
        {
            //Console.WriteLine("Number is {0}",num);
            return num;
        }

        static void Main(string[] args)
        {
            DelegateDemo d;
            DelegateDemo d1 = new DelegateDemo(add);
            DelegateDemo d2 = new DelegateDemo(mul);

            d = d1;
            d += d2;
            d(5);
            Console.WriteLine("Value of Num d: {0}", print());
            d1(10);
            Console.WriteLine("Value of Num d1: {0}", print());
            d2(20);
            Console.WriteLine("Value of Num d2: {0}", print());
            Console.ReadKey();
        }
    }
}
