using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //The interface segragation principle is all about separating interfaces.Basically multiple specific interface is better than generic single interface
    interface ILead
    {
         void AssignTask();
         void CreateSubTask();
    }
    interface IProgrammer
    {
        void WorkOnTask();
    }
    class Programmer :IProgrammer
    {
       public void WorkOnTask()
        {

        }
    }

    class TeamLead :ILead,IProgrammer
    {
        public void AssignTask()
        {

        }
        public void CreateSubTask()
        {

        }
        public void WorkOnTask()
        {

        }
    }

    class Manager: ILead
    {
        public void AssignTask()
        {

        }
        public void CreateSubTask()
        {

        }
    }
}
