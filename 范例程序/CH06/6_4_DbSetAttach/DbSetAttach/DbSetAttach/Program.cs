using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSetAttach.Model;

namespace DbSetAttach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
                try
                {
                    Console.Write("{0}:", "编号");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("{0}：", "商品");
                    string name = Console.ReadLine();
                    Console.Write("{0}：", "订价");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("{0}：", "售价");
                    int sprice = int.Parse(Console.ReadLine());



                    Product mproduct = new Product
                    {
                        Id = id,
                        Name = name,
                        Price = price,
                        SPrice = sprice
                    };
                    //// Attach 之前的状态
                    //Console.WriteLine(context.Entry(mproduct).State.ToString());
                    //context.Product.Attach(mproduct);
                    //// Attach 之后的状态
                    //Console.WriteLine(context.Entry(mproduct).State.ToString());
                    //Console.ReadKey();

                    context.Entry(mproduct).State = System.Data.Entity.EntityState.Modified;
                    // context.Entry(mproduct).State = System.Data.Entity.EntityState.Modified;
                    int rowCount = context.SaveChanges();
                    Console.WriteLine("价格成功更新为 {0} !", price.ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n错误信息：{0}\n", ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
