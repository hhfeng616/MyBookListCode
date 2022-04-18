using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationFluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel()) {


                var c = context.OrderDetails.Count();
                Console.Read();

            }

        }
    }
}
