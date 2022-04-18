using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToListAsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // var t = RunAsyncQuery();

            Task<List<Products>> ps = RunAsyncQueryP();
            Console.WriteLine("开始提取数据…\n");
            List<Products> products  = ps.Result ;
            foreach (Products p in products) {
                Console.WriteLine("{0}\t{1}", p.Id, p.Name);
            }
            
            Console.ReadKey();
        }
        static async Task RunAsyncQuery()
        {
            using (var context = new KTStoreModel())
            {
                //var products = await context.Products.ToListAsync();
                await context.Products.ForEachAsync(product =>
                {
                    Console.WriteLine(product.Name);
                });
            }
        }
        static async Task<List<Products>> RunAsyncQueryP()
        {
            using (var context = new KTStoreModel())
            {
                var products = await context.Products.ToListAsync();
                return products;   
            }
        }
    }
}
