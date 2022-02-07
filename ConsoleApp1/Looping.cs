using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum options { Aggregate = 1, MinMark = 2, MaximumMark = 3, Grade = 4 };
    class student
    {
        public string Name;
        public decimal[] Marks=new decimal[5];
        public static decimal AverageMarks;

        public void getArray()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write("Subject - {0} : ", i);
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public decimal CalculateAverageMarks()
        {
            decimal sum = 0;
            for (int i =0;i<Marks.Length;i++)
            {
                sum = sum + Marks[i];
            }
            AverageMarks = sum / 2;
            Console.WriteLine("average marks is:{0}", AverageMarks);
            return AverageMarks;
        }
        public string CalculateGrade(decimal[] Marks)
        {
            decimal sum=0, per;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum = sum + Marks[i];
            }
            per = AverageMarks * 100 / sum;
            if(per>=90)
            {
                Console.WriteLine("Grade is: A");
                return "A";
            }
            else if(per>80)
            {
                Console.WriteLine("Grade is: B");
                return "B";
            }
            else if (per > 70)
            {
                Console.WriteLine("Grade is: C");
                return "C";
            }
            else
            {
                Console.WriteLine("Grade is: D");
                return "D";
            }

        }
        public void displayName(string name)
        {
            Console.WriteLine(this.Name = name);
        }
        public void minimum()
        {
            int location = 0;
            for (int i = 1; i < Marks.Length;i++)
                if (Marks[i] < Marks[location])
                    location = i;
            Console.WriteLine("minumum marks is:{0}", Marks[location]);
        }
        public void maximum()
        {
            int location = 0;
            for (int i = 1; i < Marks.Length; i++)
                if (Marks[i] > Marks[location])
                    location = i;
            Console.WriteLine("Maximum marks is:{0}", Marks[location]);
        }
        static void Main(string[] args)
        {
          
            student s1 = new student();
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
          
            s1.getArray();
           
            Console.WriteLine("Press 1-Aggregate:");
            Console.WriteLine("Press 2-MinMark:");
            Console.WriteLine("Press 3-MaximumMark:");
            Console.WriteLine("Press 4-Grade:");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
          
            switch (choice)
            {
                case (int)options.Aggregate:
                    s1.displayName(name);
                    Console.WriteLine(AverageMarks);
                    break;

                case (int)options.MinMark:
                    s1.minimum();
                    break;

                case (int)options.MaximumMark:
                    s1.maximum();
                    break;

                case (int)options.Grade:
                    s1.CalculateGrade(s1.Marks);
                    break;

                default:
                    Console.WriteLine("default");
                
                    break;
            }

            Console.ReadKey();
        }
    }
}
