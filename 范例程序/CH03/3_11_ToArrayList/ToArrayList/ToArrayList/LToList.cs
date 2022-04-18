using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToArrayList
{
    class LToList
    {
        public static void ToList() {

            using (var context = new KTStoreModel()){

                //var list = from product in context.Products
                //           where checkPrice(product.Price)
                //           select product;

                IQueryable<Product> query = from product in context.Products                           
                           select product;

                var list =from product in query.ToList() 
                          where checkPrice(product.Price)
                          select product;

             

                Console.WriteLine("定价超过 150 的商品项数：{0}", list.Count());
            }
        }
        static bool checkPrice(int price)
        {

            if (price > 150)
                return true;
            else
                return false;                   

        }

    }
}
