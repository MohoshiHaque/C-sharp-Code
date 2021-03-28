using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicVariable = 12;
            Console.WriteLine(dynamicVariable + "Type is: " + dynamicVariable.GetType());
            dynamicVariable = "Bangladesh";
            Console.WriteLine(dynamicVariable + "Type is: " + dynamicVariable.GetType());
            
            print("12", 12);
            Console.ReadLine();
        }

        public static void print(dynamic x, dynamic y)
        {
            Console.WriteLine(x + "-" + y);
        }
    }
}
