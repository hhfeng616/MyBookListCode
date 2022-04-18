using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TransactionScopeDemo.Model;
namespace TransactionScopeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                using (KTStoreContext context = new KTStoreContext())
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
                        KTStoreContext context_s = new KTStoreContext(
                            context.Database.Connection, 
                            contextOwnsConnection: false);
                        context_s.Database.ExecuteSqlCommand(
                            "UPDATE Product SET SPrice =0 WHERE Id=10 ");
                        
                        scope.Complete();
                        Console.WriteLine("更新了 {0} 项数据", c);
                    }
                    catch (Exception e) {
                        Console.WriteLine("事务处理失败");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}

