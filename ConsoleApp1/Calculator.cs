using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the {0} and {1} is {2}", num1, num2, num1 + num2);
            Console.WriteLine("The subtraction of {0} and {1} is {2}", num1, num2, num1 - num2);
            Console.WriteLine("The multiplication of  {0} and {1} is {2}", num1, num2, num1 * num2);
            Console.WriteLine("The division of  {0} and {1} is {2}", num1, num2, num1 / num2);

            Console.ReadKey();
        }
    }
}
