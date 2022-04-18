using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveChangesAsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欲修改商品的编号：");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("新的商品名称：");
            string name = Console.ReadLine();
            Task<int> t = RunSaveChangesAsync(id, name);
            Console.WriteLine("\n正在更新数据 ... \n");
            Console.WriteLine("更新数据的项数：{0}", t.Result);
            Console.ReadLine();
        }
        static async Task<int> RunSaveChangesAsync(int id, string name)
        {
            int c = 0;
            using (var context = new KTStoreModel())
            {
                Product product = context.Products.Find(id);
                if (product != null)
                {
                    product.Name = name;
                    c = await (context.SaveChangesAsync());
                }
            }
            return c;
        }
    }
}