using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OCP
    {
        static void Main(string[] args)
        {
            Employee e1 = new PermanentEmployee(1, "John");
            Employee e2 = new TemporaryEmployee(2, "Jason");
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                e1.ToString(),
                e1.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              e2.ToString(),
              e2.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee()
        {
        }
        public Employee(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
