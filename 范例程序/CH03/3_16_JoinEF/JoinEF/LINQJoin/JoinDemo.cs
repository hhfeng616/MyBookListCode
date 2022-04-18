using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    class JoinDemo
    {
        public static void DoJoin() {

            using (var context = new KTStoreModel())
            {
                var products = from category in context.Category
                               join product in context.Product on
                               category.Id equals product.CategoryId
                               select new
                               {
                                   Category = category.Name,
                                   Product = product.Name,
                                   Price = product.Price

                               };
                foreach (var cp in products)
                {
                    Console.WriteLine("分类：{0}\t{1}\t价格：{2}", 
                        cp.Category, cp.Product, cp.Price);
                }

            }

        }


    }
}
