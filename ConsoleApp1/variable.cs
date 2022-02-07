using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class variable
    {
        //we can declare both as a global variable
        object i = 0;
        dynamic j = 0;
        static void Main(String[] args)
        {
            var test = 5;//var is local variable
            //test = 'hello';//give error
            //test = 10;

            object test1 = 10;
            test1 = "hello";

            dynamic test3 = 20;
            test3 = "hello";

            //give error here we need to type caste 
           // string assign = test1;
            
            string assignObject = test1.ToString();// now it will work
            string assignDynamic = test3;

        }
    }
}
