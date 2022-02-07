using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //A subclass should be a substitutable by its base class without having any -ve impact to the caller
   public abstract class Birds
    {
        public abstract void bird();
       // public void fly() { }-->not meaningful wrong type of implementation
    }
    public class flyingBird
    {
        public void fly() { }
       
    }
   public class ostrich : Birds
    {
    
            public override void bird()
        {
            Console.Write("ostrich class");
        }
       
    }
    class pigeon : flyingBird { }

    class demoLSP
    {
        static void Main(string[] args)
        {
            Birds b = new ostrich();
            b.bird();
            Console.ReadKey();
        }
    }
    
}
