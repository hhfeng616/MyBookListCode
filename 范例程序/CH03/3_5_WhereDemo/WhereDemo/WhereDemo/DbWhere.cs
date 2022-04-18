using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereDemo
{
    class DbWhere
    {

        public  static void DoWhere() {

            using (var context = new KTStoreModel())
            {
                IEnumerable<Product> products =
                    from product in context.Products.ToList()
                    where CheckPrice(product.Price)
                    select product;

                //IEnumerable<Product> products =
                //    context.Products.Where(
                //        product => product.Price >= 80 &&
                //        product.Price <= 160);
                            

                Console.WriteLine("价格介于 80-160 元的商品：\n");
                foreach (var product  in products)
                {
                    Console.WriteLine("价格：{0}\t{1}", product.Price, product.Name);
                }

            }
        }

        static bool CheckPrice(int? price) {

            bool b = price >= 80 && price <= 160;

            return b;

        }
    }
}
