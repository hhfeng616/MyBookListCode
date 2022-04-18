using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    class LGroupIntoSelect
    {
        public static void CroupIntoSelect()
        {
            using (var context = new KTStoreModel())
            {
                IEnumerable<GCProduct> pgroup  = 
                    from category in context.Category
                    join product in context.Product on
                    category.Id equals product.CategoryId
                    into productgroup
                    select new GCProduct()
                    {
                        CategoryName = category.Name,
                        Products = productgroup
                    };
                foreach (var category in pgroup)
                {
                    Console.WriteLine("\n{0}：{1}\n",
                        category.CategoryName, category.Products.Count());
                    foreach (var product in category.Products)
                    {
                        Console.WriteLine("　{0}", product.Name);
                    }
                }              
            }
        }
    }
    public class GCProduct {

        public string CategoryName { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
