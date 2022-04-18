using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTimestamp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel()) {

                var c  = context.Product.Count();
                Console.WriteLine(c);
                Console.Read();

            }
        }
    }
}
