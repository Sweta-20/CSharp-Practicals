using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Encapsulation
    {
        private string studentName;
        private int studentAge;

        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                // studentName = "Meera";
                studentName = value;
            }
        }

        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                //studentAge = 20;
                studentAge = value;
            }

        }
    }

    class second
    {
        static void Main(string[] args)
        {
            Encapsulation e = new Encapsulation();
            e.Name = "radhika";
            e.Age = 21;

            Console.WriteLine("Name: " + e.Name);
            Console.WriteLine("Age: " + e.Age);
            Console.ReadKey();
        }
    }

    
}
