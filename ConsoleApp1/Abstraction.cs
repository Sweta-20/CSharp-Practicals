using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Laptop
    {
        private string brand;

        private string model;

        public string BrandModel
        {
            set
            {
                brand = value;
            }
            get
            {
                return brand;  
            }
        }
        public string Model
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }
        public void LaptopDetails()

        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
        }

        private void MotherBoardInfo()

        {
            Console.WriteLine("MotherBoard Information");
        }

        static void Main(string[] args)
        {
            Laptop lp = new Laptop();
            lp.brand = "Hp";
            lp.model = "15s-dy3501TU";
            lp.LaptopDetails();
            lp.MotherBoardInfo();

            Console.Read();
        }
    }
}
