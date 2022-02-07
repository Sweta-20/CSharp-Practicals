using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyDel();
    class ProcessBusinessLogic
    {
       public event MyDel ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here...
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();

        }
        public static void  bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked!");
            
        }
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
        }
    }
}
