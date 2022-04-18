using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            QuantifierEFDemo.DoQuantifier();


            ContainDemo.DoContain();


            AnyDemo.DoAny();


            AllDemo.DoAll();

            Console.ReadKey();
        }
    }
}
