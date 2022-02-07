using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class internalDemo // bedefault class is internal and class can never be private protected
    {
        public int value;
       protected internal int iValue;// internal will access in the same assembly means all namespace will store in assembly

        public void setValue(int val,int ival)
        {
            value = val;
            iValue = ival;
        }
        private void displayValue()
        {
            Console.WriteLine("value:  {0} and Ivalue {1}", value,iValue);
            
        }
         internal void display1()
        {
            Console.WriteLine("value: {0} and Ivalue:{1}", value, iValue);
        }
        protected void display2()
        {
            Console.WriteLine("value = {0}", value);

        }
        public void display3()
        {
            
            Console.WriteLine("value: {0} and Ivalue:{1}", value, iValue);
        }
    }

    class maindemo: internalDemo
    {
        static void Main(string[] args)
        {
           
            internalDemo i1 = new internalDemo();
            maindemo d = new maindemo();
            // Accessible in class Program
            i1.setValue(20,10);
           // i1.displayValue();it will give error
            i1.display1();
            d.setValue(10,20);
            d.display2();
            Console.ReadKey();
        }
    }
}
