using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    class Program
    {
        public delegate int CalculatorHandler(int f1, int f2); //delegate এর return type অবশ্যই function এর return টাইপ same হতে হবে।
        static void Main(string[] args)
        {
            CalculatorHandler calculatorHandler = Add;
            InvokeDelegates(Add, 12, 24); //একটা method এ function parameter হিসাবে নিয়েছি

            CalculatorHandler calculatorHandler1 = Sub;
            InvokeDelegates(Sub, 12, 24);//একটা method এ function parameter হিসাবে নিয়েছি

            Console.ReadLine();
        }

        // first function
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        //অন্য একটা Method এ function parameter হিসাবে pass করার জন্য

        public static void InvokeDelegates(CalculatorHandler calculatorHandler, int fnumber, int snumber) //user input নেওয়ার জন্য input দিয়ে দিয়েছি
        {
            int result = calculatorHandler.Invoke(fnumber, snumber);
            Console.WriteLine(result);
        }
    }
}
