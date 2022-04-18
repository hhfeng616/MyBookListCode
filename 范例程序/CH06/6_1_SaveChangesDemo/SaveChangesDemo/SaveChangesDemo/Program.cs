using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveChangesDemo.Model;
using System.Data.Entity;

namespace SaveChangesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
                try
                {                    
                    Console.Write("{0}：", "商品");
                    string name = Console.ReadLine();
                    Console.Write("{0}：", "订价");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("{0}：", "售价");
                    int sprice = int.Parse(Console.ReadLine());

                    //Product product = new Product();
                    //product.Name = name; 
                    //product.Price = price;
                    //product.SPrice = sprice;

                    Product product = new Product
                    {                        
                        Name = name,
                        Price = price,
                        SPrice = sprice
                    };

                    Console.WriteLine(context.Entry(product).State.ToString());
                    context.Product.Add(product);
                    Console.WriteLine(context.Entry(product).State.ToString());
                    //context.Entry(product).State =  EntityState.Added  ;                 
                    int count = context.SaveChanges();                    
                    Console.WriteLine("添加 {0} 项数据 !", count);
                    
                  

                    //多项数据
                    /*
                    bool loop = true;
                    do
                    {
                        Console.Write("{0}：", "商品");
                        string name = Console.ReadLine();
                        Console.Write("{0}：", "订价");
                        int price = int.Parse(Console.ReadLine());
                        Console.Write("{0}：", "售价");
                        int sprice = int.Parse(Console.ReadLine());
                        Product product = new Product
                        {
                            Name = name,
                            Price = price,
                            SPrice = sprice
                        };
                        context.Product.Add(product);
                        Console.Write("持续添加商品？（true/false）");
                        loop = bool.Parse(Console.ReadLine());
                    } while (loop);
                    int count = context.SaveChanges();
                    Console.WriteLine("添加 {0} 项数据 !", count);
                    */
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n错误信息：{0}\n", ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
