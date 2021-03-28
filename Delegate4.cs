using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
    class Program
    {
        public delegate int CalculatorHandler(int f1, int f2);
        static void Main(string[] args)
        {

            CalculatorHandler calculatorHandler = delegate (int firstNumber, int secondNumber)
             {
                 return firstNumber + secondNumber;
                

             };
            InvokeDelegates(calculatorHandler,12,40);
            Console.ReadLine();


        }

        public static void InvokeDelegates(CalculatorHandler calculatorHandler, int fnumber, int snumber) //user input নেওয়ার জন্য input দিয়ে দিয়েছি
        {
            int result = calculatorHandler.Invoke(fnumber, snumber);
            Console.WriteLine(result);
        }
    }
}
