using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySQLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel())
            {
                ObjectContext oc = (
                    (IObjectContextAdapter)context).ObjectContext;

                ////无参数查询

                ////String sql =
                ////    "SELECT VALUE product " +
                ////    "FROM Products AS product " +
                ////    "WHERE product.Price > 1000 " +
                ////    "ORDER BY product.Price";
                ////ObjectQuery<Product> products = oc.CreateQuery<Product>(sql);


                //参数查询

                String sql =
                    "SELECT VALUE product " +
                    "FROM Products AS product " +
                    "WHERE product.Price > @price1 " +
                    "AND product.Price < @price2 " +
                    "ORDER BY product.Price ";

                var op1 = new ObjectParameter("price1", typeof(int));
                op1.Value = 100;
                var op2 = new ObjectParameter("price2", typeof(int));
                op2.Value = 260;
                ObjectParameter[] ps = new ObjectParameter[] { op1, op2 };
                ObjectQuery<Product> products = oc.CreateQuery<Product>(sql, ps);
                foreach (Product p in products)
                {
                    Console.WriteLine("定价：{1}\t{0} ", p.Name, p.Price);
                }
            }
            Console.ReadLine();
        }
    }
}
