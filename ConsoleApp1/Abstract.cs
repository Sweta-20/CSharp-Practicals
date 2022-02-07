using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   abstract class Abstract
    {
       public void Display()
        {
            Console.WriteLine("normal method called");
        }
        public abstract void showData();
    }
     class AbstDemo:Abstract
    {
        public override void showData()
        {
            Console.WriteLine("Abstract method called");
        }

        static void Main(string[] args)
        {
            Abstract Aobj = new AbstDemo();
            Aobj.showData();
            Aobj.Display();

            Console.ReadKey();
        }
    }
}
