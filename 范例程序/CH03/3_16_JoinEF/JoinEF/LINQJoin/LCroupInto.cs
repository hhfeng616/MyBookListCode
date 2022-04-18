using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    class LCroupInto
    {
        public static void CroupInto()
        {
            using (var context = new KTStoreModel())
            {
                int n = 1; 
                IEnumerable<IEnumerable<Product>> pgroup = 
                    from category in context.Category
                    join product in context.Product on
                    category.Id equals product.CategoryId
                    into productgroup
                    select productgroup   ;

                foreach (var products in pgroup)
                {                  
                    Console.WriteLine("\n分类 {0} 数据项数：{1}\n",
                        n, products.Count());
                    foreach (var product in products)
                    {                        
                        Console.WriteLine("\t{0}", product.Name);
                    }
                    n++;
                }               
            }
        }
    }
}
