using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        string pr;
        Program1(string pr)
        {
            Console.WriteLine("main class constructor is called");
            Console.WriteLine(this.pr = pr);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello program1");
           
            //demo class object
            demo D1 = new demo();
            D1.a = 30;
            Console.WriteLine(D1.data);
            Console.WriteLine(D1.a);
            D1.getData();

            //main class object
            Program1 P1 = new Program1("hello program1");

            Console.ReadKey();
        }
    }
    class demo
    {
        public string data = "data member";
        public int a= 20;
        public demo()
        {
            Console.WriteLine("Constructor is called");
        }
        public void getData()
        {
            Console.WriteLine(this.data);
            
        }
       
    }

    //find use of internal access specifiers
    //1.public
    //2.private
    //3.protected
}
