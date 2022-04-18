using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel()) {
                Console.WriteLine(context.OrderDetails.ToString());
                Console.Read();
            }
        }
    }
}
