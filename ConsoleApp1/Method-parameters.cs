using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //name parameter
    class Method_parameters
    {
        public static void addstr(string s1, string s2, string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine("Final string is: " + result);
        }
        static public void Main()
        {
            // calling the static method with named 
            // parameters without any order
            addstr(s1: "how", s2: "are", s3: "you");
            Console.Read();

        }
    }
    //Refrence value parameter
   class Refrence
    {
        public int value=10;

        public static void addstr(ref int val)
        {
            Console.WriteLine("Before Refrence value is : {0}",val);
            val = 15;
            Console.WriteLine("After Refrence value is : {0}", val);
        }
        static void Main()
        {
            Refrence r = new Refrence();
            addstr(ref r.value);

            Console.WriteLine("After value change in main method :{0}",r.value);
            Console.Read();
        }

    }

    class Value
    {
        public int value = 10;

        public static void addstr( int val)
        {
            Console.WriteLine("Before pass by value is : {0}", val);
            val = 15;
            Console.WriteLine("After pass by value is : {0}", val);
        }
        static void Main()
        {
            Value r = new Value();
            addstr( r.value);

            Console.WriteLine("After value change in main method :{0}", r.value);
            Console.Read();
        }

    }

    class Out
    {
        public static void addstr(out int val)
        { 
            val = 15;
            Console.WriteLine("Out value is : {0}", val);
        }
        static void Main()
        {
            int num=10;
            addstr(out num);
            Console.WriteLine("After value change in main method :{0}",num);
            Console.Read();
        }

    }
}
