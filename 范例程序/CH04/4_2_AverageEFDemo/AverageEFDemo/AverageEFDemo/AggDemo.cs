using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageEFDemo
{
    class AggDemo
    {
        public static void DoAgg()
        {
            using (var context = new KTStoreModel())
            {
                int count = context.Products.Count();
                double average = context.Products.Average(p => p.Price);
                int max = context.Products.Max(p=>p.Price);
                int min = context.Products.Min(p => p.Price);   
                int sum = context.Products.Sum(p => p.Price);

                Console.WriteLine(
                    "商品数量：{0}\n平均价格：{1}\n最高价:{2}\n最低价：{3}\n商品总价值：{4}",
                    count, average, max, min, sum);             
            }
        }


    }
}
