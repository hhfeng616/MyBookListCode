using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    class LSelectManyBook
    {
        public static void SMDemo()
        {

            using (var context = new KTStoreModel())
            {

               // var products = from category in context.Categories
               //                where category.Id == 1 
               //                from product in category.Products
               //                select product;


                 var products = context.Categories.
                     Where(c => c.Id == 1).
                     SelectMany(c => c.Products).                    
                     Select(p => p);

                Console.WriteLine("\n");
                Console.WriteLine("图书清单\n");
                foreach (var p in products)
                {
                    Console.WriteLine("　价格：{0}\t{1}", p.Price, p.Name);
                }


            }

        }
    }
}
