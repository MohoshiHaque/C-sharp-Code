using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            int? a = 12;
            int? c = null;
            Console.WriteLine(c);

            int? b = a ?? 20;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
