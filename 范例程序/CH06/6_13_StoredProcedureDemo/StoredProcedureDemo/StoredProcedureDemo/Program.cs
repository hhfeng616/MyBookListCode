using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoredProcedureDemo.Model;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace StoredProcedureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context= new KTStoreContext()){
                //string sp = "ProductList";
                //List<Product> products  = 
                //    context.Products.SqlQuery(sp).ToList()  ;
                //foreach (Product product in products) {
                //    Console.WriteLine("{0}\t价格:{1}",
                //        product.Name,product.Price );
                //}


                string sp = "GetProductByName @P1";            
                List<Product> products =
                    context.Products.SqlQuery(
                        sp, 
                        new SqlParameter("P1", "移动")
                        ).ToList();
                foreach (Product product in products)
                {
                    Console.WriteLine("{0}\t价格:{1}",
                        product.Name, product.Price);
                }
                Console.ReadKey();

                sp = "SetSPriceById @P1,@P2";
                object[] parameters = {
                    new SqlParameter("P1", 100),
                    new SqlParameter("P2", 10),
                };
                int count = context.Database.ExecuteSqlCommand(sp, parameters);
                Console.WriteLine(count);
                Console.ReadKey();

            }
        }
    }
}

