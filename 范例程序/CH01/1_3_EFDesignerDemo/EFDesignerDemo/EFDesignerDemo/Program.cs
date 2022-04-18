using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDesignerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreModelContainer container = new KTStoreModelContainer();
            int c = container.ProductSet.Count();
            Console.WriteLine(c);
        }
    }
}
