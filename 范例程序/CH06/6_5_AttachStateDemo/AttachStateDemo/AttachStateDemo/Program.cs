using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttachStateDemo.Model;
namespace AttachStateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1查询　2添加　");
            int m = int.Parse(Console.ReadLine());

            using (KTStoreContext context = new KTStoreContext())
            {

                if (m == 1)
                {
                    Console.Write("\n商品编号：");
                    int Id = int.Parse(Console.ReadLine());
                    using (KTStoreContext context1 = new KTStoreContext())
                    {
                        Product product = context1.Product.Find(Id);
                        if (product != null)
                        {
                            Console.WriteLine("\n{0}　{1}\t订价{2}　售价{3}",
                                product.Id, product.Name, product.Price, product.SPrice);
                        }
                        else
                        {
                            Console.WriteLine("\n无相关数据 !");
                            Console.ReadKey();
                            return;
                        }
                    }
                    Console.Write("\nD删除　U更新 ");
                    string du = Console.ReadLine();
                    if (du == "D")
                    {
                        Product product = new Product { Id = Id };
                        context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                        Console.WriteLine("\n数据删除完成 !");
                        Console.ReadKey();
                        return;
                    }
                    else if (du == "U")
                    {
                        Console.Write("\n");
                        Console.Write("名称：");
                        string name = Console.ReadLine();
                        Console.Write("订价：");
                        string price = Console.ReadLine();
                        Console.Write("售价：");
                        string sprice = Console.ReadLine();

                        Product product = new Product
                        {
                            Id = Id,
                            Name = name,
                            Price = int.Parse(price),
                            SPrice = int.Parse(sprice)
                        };
                        context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("\n数据更新完成 !");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (m == 2)
                {
                    Console.Write("\n");
                    Console.Write("名称：");
                    string name = Console.ReadLine();
                    Console.Write("订价：");
                    string price = Console.ReadLine();
                    Console.Write("售价：");
                    string sprice = Console.ReadLine();

                    Product product = new Product
                    {
                        Name = name,
                        Price = int.Parse(price),
                        SPrice = int.Parse(sprice)
                    };

                    context.Entry(product).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                    Console.WriteLine("\n添加一项商品数据完成 !");
                    Console.ReadKey();
                    return;

                }
            }
        }
    }
}