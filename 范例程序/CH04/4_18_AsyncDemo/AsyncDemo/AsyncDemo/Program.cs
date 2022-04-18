using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = RunAsyncQuery();
            Console.WriteLine("载入数据…\n");
            Console.ReadKey();
        }
        static async Task RunAsyncQuery()
        {
            using (var context = new KTStoreModel())
            {
                var product = await context.Products.FirstAsync();
                Console.WriteLine("第一项数据：{0}\t{1}\t 价格  {2}", product.Id, product.Name, product.Price);
                var c = await context.Products.CountAsync();
                Console.WriteLine("数据项数：{0}", c.ToString());
                var sum = await context.Products.Select(p => p.Price).SumAsync();
                Console.WriteLine("商品总价值：{0}", sum.ToString());
                var a = await context.Products.Select(p => p.Price).AverageAsync();
                Console.WriteLine("平均售价：{0}", a.ToString());
            }

        }
    }
}
