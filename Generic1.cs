using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> student = new Student<int>();
            student.Name = "Rasel";
            student.Success = 1;
            var student1 = new Student<string>() { Name = "Mohoshi", Success = "pass" };
            var student2 = new Student<bool>() { Name = "Mohoshi", Success = false };
            //Console.WriteLine(student.Success);
             Console.WriteLine(student1.Success);
            Console.WriteLine(student2.Success);
            Console.ReadLine();
        }
        public static void Print(Student<int> student)
        {
            Console.WriteLine("Name: "+student.Name+"Result: "+student.Success);

        }
    }

    public class Student<T>
    {
        public string Name { get; set;}
        public T Success { get; set;}
        
    }
}
