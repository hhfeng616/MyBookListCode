using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenEFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel())
            {
                IEnumerable<Product> rp = Enumerable.Repeat<Product>(
                    new Product()
                    {
                        Id = 100,
                        Name = "Entity Framework 实用精解",
                        Category = "Book",
                        Price = 80
                    }, 12);
                foreach (var p in rp)
                {
                    Console.WriteLine(
                        "Id：{0}\t　Name：{1}\t　Price：{2}\t　Category：{3}",
                        p.Id, p.Name, p.Price, p.Category);
                }
                Console.Read();
            }
        }
    }
}
