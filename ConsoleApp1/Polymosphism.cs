using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bird
    {
        public void voice()
        {
            Console.WriteLine("turr turr");
        }
    }
    class Duck:Bird
    {
        public void voice()
        {
            Console.WriteLine("Quack Quack");
        }

        static void Main(string[] args)
        {
            Bird myBird = new Bird();
            Duck myDuck = new Bird();
           
            myBird.voice();
            myDuck.voice();

            Console.ReadKey();
        }
    }
}
