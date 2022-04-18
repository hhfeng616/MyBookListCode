using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LocalDemo
{
    public class LoadDemo
    {

        public static void LocalLoad() {

            using (var context = new KTStoreModel()) {

                context.Database.Log = Console.WriteLine ;
                //var products=context.Product.Where(p => p.Price > 100);
                context.Product.Where(p => p.Price > 100).Load();
                var products = context.Product.Local;

                Product firstProduct = products.First();
                Console.WriteLine("\n第一项商品数据名称：{0}\n", firstProduct.Name);
                Console.WriteLine("\n所有商品数据列表：\n");
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }  
                Console.Read();           
            }
        }
    }
}
