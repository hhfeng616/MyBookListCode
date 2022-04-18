using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    class LSelectMany
    {

        public static void SMDemo() {

            using (var context = new KTStoreModel()) {



                var products = from category in context.Categories
                               from product in category.Products
                               select new
                               {
                                   CategoryName = category.Name,
                                   ProductName = product.Name
                               };
                


               // var products = context.Categories.
               //     SelectMany(c => c.Products.
               //     Select(p =>new {
               //         ProductName = p.Name,
               //         CategoryName = c.Name  }));




                foreach (var p in products)
                {
                    Console.WriteLine("分类：{0}\t{1}", p.CategoryName, p.ProductName);
                }





            }

        }
    }
}
