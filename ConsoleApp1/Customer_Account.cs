using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer_Account
    {
        string bankname="SBI";
        long customeraccountNo;
        string customername;

        Customer_Account(long C_aacno,string C_name)
        {
            this.customeraccountNo = C_aacno;
            this.customername = C_name;
        }

        public void printInfo()
        {
            Console.WriteLine("Bank Name is :{0}",this.bankname);
            Console.WriteLine("Cunstomer Account number is : {0}",this.customeraccountNo);
            Console.WriteLine("Customer number is : {0}",this.customername);
        }

        static void Main(string[] args)
        {
            Customer_Account ca = new Customer_Account(12345,"Ram");
            ca.printInfo();

            Console.ReadKey();
        }
    }
}
