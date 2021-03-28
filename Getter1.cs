using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter
{

    class Income
    {

        private int _StdId;
        private string _Name;
        private string _FName;



        // StdId property করছি
        public int StdId
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id can't be negative or zero");
                }
                else
                {
                    this._StdId = value;
                }
                
            }

            get
            {
                return this._StdId;
            }

        }

       
       // For Name property
        public string Name
        {
            set
            {
                this._Name = value;
            }

            get
            {
                return this._Name;

            }
        }


        
    }
    class Program
    {
        static void Main(string[] args)
        {

            Income x = new Income();
            x.StdId = -2;
            x.Name = "Mohoshi";
            Console.WriteLine(x.StdId);
            Console.WriteLine(x.Name);
            Console.ReadLine();
        }
    }
}
