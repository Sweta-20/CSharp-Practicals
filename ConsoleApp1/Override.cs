using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Override
    {
        string str = "computer";
        public virtual void showStr()
        {
            Console.WriteLine("string is:{0}", str);
        }
    }
    class OverrideDemo:Override
    {
        string strnew = "science";
        public override void showStr()
        {
            base.showStr();
            Console.WriteLine("string is:{0}", strnew);
        }
        static void Main(string[] args)
        {
            OverrideDemo obj = new OverrideDemo();
            obj.showStr();
            Console.ReadKey();
        }
    }
}
