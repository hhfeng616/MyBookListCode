using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new KTStoreModel())
            {
                int c = context.Products.Count();
                Console.WriteLine("{0}", c);
            }
        }
    }
}
