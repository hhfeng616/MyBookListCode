using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncludeDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new KTStoreModel()) {

                context.Database.Log = Console.Write;
                var customer = context.Customers.
                    Include("Orders.OrderDetails").
                    Include("Orders.OrderDetails.Product").
                    Where(c=>c.Id<5)  ;

                foreach(var c in customer)
                {
                    Console.WriteLine(c.ContactName);
                    foreach (var o in c.Orders)
                    {
                        Console.WriteLine("\tOrder_Id：{0}",o.Id);
                        foreach (var od in o.OrderDetails)
                        {
                            Console.WriteLine("\t\tProduct_Id：{0}\t{1}\tPrice：{2}", 
                                od.ProductId,od.Product.Name,od.Price);
                        }
                    }
                }
                Console.WriteLine("done");

            }


            //Async

            Task rasync = AsyncDemo.ToListAsyncDemo() ;
            Console.WriteLine("正在提取数据……\n");
            Console.Read();
        }

      
    }
}

