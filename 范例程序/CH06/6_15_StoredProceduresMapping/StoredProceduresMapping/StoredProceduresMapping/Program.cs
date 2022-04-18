using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoredProceduresMapping.Model;

namespace StoredProceduresMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "";
            using (KTStoreContext context = new KTStoreContext())
            {               
                Console.WriteLine("1.添加\t2.修改\t ？");
                var t = Console.ReadLine();
                Console.Write("商品名称：");
                var name = Console.ReadLine();
                Console.Write("订价：");
                var price = int.Parse(Console.ReadLine());

                if (t == "1")
                {
                    context.Product.Add(new Product { Name = name, Price = price });
                    message = "成功添加一项数据！";
                }
                else
                {
                    Console.Write("商品编号：");
                    var id = int.Parse(Console.ReadLine());
                    var product= context.Product.Where(p => p.Id.Equals(id)).Single();
                    product.Name = name;
                    product.Price = price;
                    message = "商品 "+id+" 更新完成！";
                }
                context.SaveChanges();
            }
            Console.WriteLine(message);
            Console.ReadKey();


        }
    }
}
