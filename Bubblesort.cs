using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { -2, 4, 9, 23, 12, 1, 0, -4 };
            Console.WriteLine("Original Array: ");
            int t;
            foreach(int i in x)
            {
                Console.WriteLine(i+" ");
            }

            for(int m = 0; m <= x.Length-2; m++)
            {
                for(int n=0; n <= x.Length-2; n++)
                {

                    if (x[n] > x[n+1])
                    {
                        t = x[n];
                        x[n] = x[n + 1];
                        x[n + 1] = t;
                    }

                }
            }
            Console.WriteLine("Sorted Array: ");
            foreach (int r in x){
                Console.WriteLine(r);
            }
            Console.ReadLine();

        }
    }
}
