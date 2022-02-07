using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exception
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i <= array.Length; i++)
                    Console.WriteLine(array[i]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }

            Console.ReadKey();

        }
    }
}
