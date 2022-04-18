using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstE
{
    class Program
    {
        static void Main(string[] args)
        {

            KTStoreModel model = new KTStoreModel();
            int c = model.Products.Count();
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
