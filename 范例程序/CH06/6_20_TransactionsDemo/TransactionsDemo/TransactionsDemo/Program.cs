using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsDemo.Model;
namespace TransactionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (KTStoreContext context = new KTStoreContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var products = context.Products;
                        foreach (Product product in products)
                        {
                            int p = (int)(product.Price * 0.5);
                            product.SPrice = p;
                        }
                        int c = context.SaveChanges();

                        KTStoreContext context_s = new KTStoreContext(context.Database.Connection
                            , contextOwnsConnection: false);
                        context_s.Database.UseTransaction(transaction.UnderlyingTransaction);
                        context_s.Database.ExecuteSqlCommand("UPDATE Product SET SPrice =0 WHERE Id=10 ");

                        transaction.Commit();
                        Console.WriteLine("更新了 {0} 项数据", c);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("事务处理失败");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}