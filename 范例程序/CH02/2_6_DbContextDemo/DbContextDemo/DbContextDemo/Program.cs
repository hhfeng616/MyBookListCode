using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel()) {
                // context.Database.Log = Console.Write;
                IEnumerable<Product> products =
                                    from product in context.Products
                                    select product;

                string sql = products.ToString();
                Console.WriteLine("{0}", sql);

                foreach (Product p in products)
                {
                    // Console.WriteLine(p.Name);
                }

                //// Update
                // Product fproduct = context.Products.First();
                // Console.WriteLine("{0}　{1}\t价格：{2}",
                //     fproduct.Id, fproduct.Name, fproduct.Price);

                // fproduct.Price = 69;
                // Console.WriteLine("{0}　{1}\t价格：{2}",
                //     fproduct.Id, fproduct.Name, fproduct.Price);

                //context.SaveChanges();


                //// Reload
                // context.Entry(fproduct).Reload();
                // fproduct = context.Products.First();
                // Console.WriteLine("{0}　{1}\t价格：{2}",
                //    fproduct.Id, fproduct.Name, fproduct.Price);


                //
                System.Data.Common.DbConnection dbConnection = context.Database.Connection;


                string conn = dbConnection.ConnectionString;
                string dbName = dbConnection.Database;
                string serverName = dbConnection.DataSource;
                System.Data.ConnectionState state =  dbConnection.State;

          　    Console.WriteLine(
                    "连接字符串：{0}\n数据库：{1}\n服务器：{2}\n状态：{3}"
                    , conn, dbName, serverName, state);
            }
            Console.Read();
        }
    }
}


 