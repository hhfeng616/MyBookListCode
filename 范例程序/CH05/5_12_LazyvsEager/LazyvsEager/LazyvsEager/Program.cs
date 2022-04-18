using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyvsEager
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new KTStoreModel())
            {
                context.Database.Log = Console.Write;
                // var cs = from c in context.Categories
                //         select c;

                var cs = from c in context.Categories.Include("Products")
                         select c;

                Console.WriteLine("\n\n\n开始执行 SQL 》》》\n\n");
                Category cat = cs.First();
                Console.WriteLine("\n\n\n引用导航属性 Products 》》》\n\n");
                // ICollection<Product> products = cat.Products;
                foreach(Product p in cat.Products)
                {
                    Console.WriteLine(p.Name);
                }


                // Loop
                //var cs = from c in context.Categories.Include("Products")
                //         select c;

                //foreach (Category c in cs) {
                //    Console.WriteLine("\n外层foreach");
                //    foreach (Product p in c.Products)
                //    {
                //        Console.WriteLine("\t\t内层foreach");
                //    }
                //}


                //virtual , 

                //context.Configuration.LazyLoadingEnabled = false;
                //Category cat = context.Categories.First();
                //Console.WriteLine("\n\nLoad ... \n");
                ////context.Entry(cat).Collection(c => c.Products).Load();
                //foreach (Product p in cat.Products)
                //{
                //    Console.WriteLine(p.Name);
                //}


                //Reference
                context.Configuration.LazyLoadingEnabled = false;
                var product = context.Products.First();
                context.Entry(product).Reference(p => p.Category).Load();
                Console.WriteLine("商品：{0}\t分类：{1}",
                    product.Name, product.Category.Name);


                Console.ReadKey();
            }
        }
    }
}