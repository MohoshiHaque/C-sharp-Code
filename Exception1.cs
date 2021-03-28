using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division: " + result);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide a number by zero");
            }

            Console.WriteLine("Mohoshi1");
            Console.WriteLine("Mohoshi2");
            Console.WriteLine("Mohoshi3");

            Console.ReadLine();
        }
    }
}
