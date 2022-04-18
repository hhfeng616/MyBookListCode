using System;
using System.Linq;
using RawSQLDatabase.Model;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RawSQLDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part I");
            /*  Part I  */
            using (var context = new KTStoreContext())
            {
                String sql = "SELECT Id, Name, price FROM Product ";
                DbRawSqlQuery<SProduct> query = context.Database.SqlQuery<SProduct>(sql);
                List<SProduct> products = query.ToList();
                foreach (SProduct product in products)
                {
                    Console.WriteLine("{0}\t{1}\t 售价：{2} 元",
                                  product.Id, product.Name, product.Price);

                }
            }

            Console.WriteLine("\nPart II");
            /*  Part II  */
            using (var context = new KTStoreContext())
            {
               // object[] parameters = { 8, "%移动%" };


                SqlParameter P0 = new SqlParameter("P0", 8);
                SqlParameter P1 = new SqlParameter("P1", "%移动%");
                SqlParameter[] parameters = { P1, P0 };

                String sql = 
                    "SELECT Id,Name,Price FROM Product WHERE Id > @P0 AND Name LIKE @P1";
                DbRawSqlQuery<SProduct> query = 
                    context.Database.SqlQuery<SProduct>(sql,parameters);
                List<SProduct> products = query.ToList();
                foreach (SProduct product in products)
                {
                    Console.WriteLine("{0}\t{1}\t售价：{2} 元",
                        product.Id, product.Name, product.Price);
                }
            }
            Console.ReadKey();
        }
        public class SProduct
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}


 