using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreEntities db = new KTStoreEntities();
            Console.WriteLine("商品数据项数：{0}\n", db.Product.Count());
            IEnumerable<Product> rows = db.Product.Select(x => x);
            foreach (Product p in rows)
            {
                int id = p.Id;
                string name = p.Name; int? price = p.Price;
                string category = p.Category;
                Console.WriteLine("{3}\t 订价：{2}\t{0}\t{1}", id, name, price, category);
            }
            Console.ReadKey();

        }
    }
}
