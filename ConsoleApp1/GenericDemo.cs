using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //type independent
    class GenericDemo
    {
        //public static bool AreEqual(object value1,object value2)
        //{
        //    return value1 == value2;
        //}
        public static bool AreEqual<t>(t value1, t value2)
        {
            //return value1 == value2;
            return value1.Equals(value2);
        }
    }
    class Generic
    {
        static void Main(string[] args)
        {
            bool equal = GenericDemo.AreEqual<int>(10,10);//problem is object is accepting all type
            if (equal)
            {
                Console.WriteLine("equal");
            }
            else
                Console.WriteLine("Not equal");

            Console.Read();
        }
    }
}
