using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncludeDemo
{
    public class AsyncDemo
    {
        public static async Task ToListAsyncDemo()
        {

            using (var context = new KTStoreModel())
            {


                //context.Database.Log = Console.Write;
                //var ods = await context.Orders.Include("Customer").ToListAsync();
                //foreach (var o in ods)
                //{
                //    Console.WriteLine("{0}－{1}", o.Id, o.Customer.ContactName);
                //    foreach (var od in o.OrderDetails)
                //    {
                //        Console.WriteLine("\t{0}", od.Product.Name);
                //    }
                //}

                await context.Orders.Include("Customer").ForEachAsync(o =>
                {
                    Console.WriteLine("{0}－{1}", o.Id, o.Customer.ContactName);
                    foreach (var od in o.OrderDetails)
                    {
                        Console.WriteLine("\t{0}", od.Product.Name);
                    }
                });
            }
        }
    }
}
