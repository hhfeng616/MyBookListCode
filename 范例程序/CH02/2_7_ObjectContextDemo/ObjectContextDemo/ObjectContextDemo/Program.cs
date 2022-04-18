using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContextDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new KTStoreModel())
            {

                //// ObjectContext
                ObjectContext objectContext =
                    (context as IObjectContextAdapter).ObjectContext;
                ObjectSet<Product> products = objectContext.CreateObjectSet<Product>();
                var oq = (ObjectQuery)products.Where(p => p.Price > 100 && p.Price<200);
                Console.WriteLine(  oq.ToTraceString());
                foreach(Product product in oq)
                {
                    Console.WriteLine(product.Name);
                }
                //// DbContext
                var ps= context.Products.Where(p => p.Price > 100 && p.Price < 200);
                Console.WriteLine(ps.ToString());
                foreach (Product product in ps)
                {
                    Console.WriteLine(product.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
