using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NewCal
    {
      public void calculate(int operand1,int operand2,int res)
        {
            Console.WriteLine("The sum of the {0} and {1} is {2}", operand1, operand2, res);
        }
        static void Main(String[] args)
        {
            NewCal obj = new NewCal();
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter an operator (+, -, *,/):");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '+':
                    int add = num1 + num2;
                    obj.calculate(num1,num2,add);
                    break;
                case '-':
                    int sub = num1 - num2;
                    obj.calculate(num1, num2, sub);
                    break;
                case '*':
                    int mul = num1 * num2;
                    obj.calculate(num1, num2, mul);
                    break;
                case '/':
                    int divide = num1 / num2;
                    obj.calculate(num1, num2, divide);
                    break;

                default:
                    Console.WriteLine("Entered wrong operator");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
