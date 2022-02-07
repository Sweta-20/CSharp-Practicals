using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NewLooping
    {
      static void Main(string[] args)
        {
            //while loop
            Console.WriteLine("While loop..");
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //do -while loop
            Console.WriteLine("Do-While loop..");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 5) ;
            //for-each loop
            Console.Write("Foreach loop..");
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int num in array)
            {
                if (num == 3)
                    continue;
                Console.WriteLine(num);
                if (num == 5)
                    break;
            }

            Console.ReadKey();
        }

    }
}
