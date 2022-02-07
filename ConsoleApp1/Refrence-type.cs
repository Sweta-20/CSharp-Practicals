using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Refrence_type
    {   
        //refrence type are storing the address where the value is being stored.
        //string,arrays,class,interface,delegates
        public int age;
        public string name;
        class user1
        {
            static void Main(string[] args)
            {
                Refrence_type rt = new Refrence_type();
                rt.age = 20;
                rt.name = "sweta";

                Refrence_type rt1 = rt;
                Refrence_type rt2 = rt;

                rt.name = "sarita";

                Console.WriteLine(rt.name);
                Console.WriteLine(rt1.name);
                Console.WriteLine(rt2.name);

                Console.ReadKey();
            }
        }
    }

    struct Value_type
    {
        //value type are those who store their data in their own memory space in [stack]
        //int,float,char,enum,struct likewise
        public int age;
        public string name;

        class user
        {
            static void Main(string[] args)
            {
                Value_type vt = new Value_type();
                vt.age = 20;
                vt.name = "sweta";

                Value_type vt1 = vt;
                Value_type vt2 = vt;

                vt.name = "sarita";

                Console.WriteLine(vt.name);
                Console.WriteLine(vt1.name);
                Console.WriteLine(vt2.name);

                Console.ReadKey();
            }
        }
        
    }
}
