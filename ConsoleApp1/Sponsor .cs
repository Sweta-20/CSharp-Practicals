using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sponsor
    {
        protected string owner = "Rakuteen";

        static void Main(string[] args)
        {
            Team t = new Team();
            Console.WriteLine(t.printInfo());
            Console.ReadKey();
        }
    }

    class Team:Sponsor
    {
        private string teamName="Abc";

        public string printInfo()
        {
            return owner + teamName;
        }
        static void Main(string[] args)
        {
            Team t = new Team();
            Console.WriteLine("hello");
            Console.WriteLine(t.printInfo());
            Console.ReadKey();
        }

    }
}
