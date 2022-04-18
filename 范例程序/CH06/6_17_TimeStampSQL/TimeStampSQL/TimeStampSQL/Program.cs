using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStampSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel())
            {
                Product product = context.Product.Where(p => p.Id == 1).First();
                long ts = BitConverter.ToInt64(product.Timestamp, 0);
                Console.WriteLine("Name:{0}\t Quantity:{1}\t TimeStamp:{2}",
                    product.Name, product.Quantity, ts);
                Console.WriteLine("按任意键执行SQL更新…");
                Console.ReadKey();
                context.Database.ExecuteSqlCommand("UPDATE Product Set Quantity = 100 ");
                product.Quantity = 119;
                context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}

