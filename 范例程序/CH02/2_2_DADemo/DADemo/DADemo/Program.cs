using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context =new KTStoreModel())
            {
                var products = context.Products;
                Console.WriteLine(products.Count());

                
            }

            Console.ReadKey();
            
        }
    }
}
