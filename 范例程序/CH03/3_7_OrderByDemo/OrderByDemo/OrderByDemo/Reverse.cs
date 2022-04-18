using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByDemo
{
    class Reverse
    {
        public static void DoReverse()
        {
            using (var context = new KTStoreModel())
            {

                var products = context.Products.OrderBy(p => p.Price).ToList();
                products.Reverse() ;
                foreach (var product in products)
                {
                    Console.WriteLine("价格：{0}\t{1}",
                        product.Price, product.Name);
                }
            }
        }
    }
}
