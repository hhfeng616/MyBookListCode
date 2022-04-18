using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningDemo
{
    class SkipTakeEF
    {
        public static void DoSkipTake() {

            using (var context = new KTStoreModel()) {

                Console.Write("\n分页数据项数：　");
                int pcount = int.Parse( Console.ReadLine());

                Console.Write("\n页数：　");
                int pages = int.Parse(Console.ReadLine());

                Console.WriteLine("\n第 {0} 个分页数据：　\n", pages);
                var products = (from product in context.Products
                                orderby product.Id
                                select product).                               
                                Skip((pages - 1) * pcount).
                                Take(pcount);

                foreach(var product in products)
                {
                    Console.WriteLine("　{0}\t{1}", product.Id, product.Name);
                }

            }
        }
    }
}
