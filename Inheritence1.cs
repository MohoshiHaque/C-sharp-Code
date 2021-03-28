using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{

    class vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut");
        }
    }

    class Car: vehicle
    {
        public string model = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.model);

            Console.ReadLine();
        }
    }
}
