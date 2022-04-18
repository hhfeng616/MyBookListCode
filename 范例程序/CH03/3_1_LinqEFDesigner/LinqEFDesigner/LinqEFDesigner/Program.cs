using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEFDesigner
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new KTStoreEntities()) {

                //var products = from product in context.Product
                //               select product;

                var products = context.Product.Select(p => p);


                foreach (Product product in products)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
