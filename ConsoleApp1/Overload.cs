using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Overload
    {
        public void add(int a,int b)
        {
            int answer = a + b;
            Console.WriteLine(answer);
        }
        public void add(int a,int b,int c)
        {
            int answer = a + b + c;
            Console.WriteLine(answer);
        }
        public double add(double a, double b)
        {
            double answer = a + b;
            return answer;
        }
        public static void Main(string[] args)
        {
            Overload obj = new Overload();
            obj.add(5, 5);
            obj.add(10, 10,10);
            double answer= obj.add(10.5, 10.5);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
