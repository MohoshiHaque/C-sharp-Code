using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyformisim
{
    class myclass
    {
        private int _age = 30;

        public virtual int age
        {
            set
            {
                this.age = age;
            }
            get
            {
                return _age;
            }
        }
    }

    class myclass2:myclass
    {
        private  int _age = 35;
        public override int age
        {
            set
            {
                this.age = age;
            }
            get
            {
                return _age;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass data = new myclass2();
            Console.WriteLine(data.age);
            Console.ReadLine();

        }
    }
}
