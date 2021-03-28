using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("The list: ");
            foreach(var i in numbers)
            {
                Console.Write(i);
                Console.WriteLine();
            }
            //Func<int, int> square = x => x * x; // প্রথম int আমার input এর জন্য, দ্বিতীয়টি result এর জন্য।
            //Console.WriteLine(square(5));
            Console.ReadLine();
        }
    }
}
