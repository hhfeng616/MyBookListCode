using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using RawSQLDemo.Model;

namespace RawSQLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
                try
                {
                    String sql = "SELECT * FROM Product ";
                    DbSqlQuery<Product> query = context.Products.SqlQuery(sql);
                    List<Product> products = query.ToList();

                    foreach (Product product in products)
                    {
                        Console.WriteLine("{0}\t售价：{1}", product.Name, product.Price);
                    }
                    Console.WriteLine("\n商品项数：{0}", products.Count());
                }
                catch (Exception ex) {
                    Console.WriteLine("\n错误信息：{0}\n",ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
