using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel())
            {

                var c = context.Products.Count();
                Console.WriteLine(
                    "Products数据表数据项数：{0}", c);
            }
            Console.ReadKey();
        }
    }
}
