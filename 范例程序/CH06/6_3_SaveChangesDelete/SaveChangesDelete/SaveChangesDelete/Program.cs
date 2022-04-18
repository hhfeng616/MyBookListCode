using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveChangesDelete.Model;

namespace SaveChangesDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
                try
                {
                    Console.Write("{0}:", "商品编号");
                    int id = int.Parse(Console.ReadLine());
                    Product product = context.Product.Find(id);


                    //Console.WriteLine(context.Entry(product).State.ToString());
                    //Console.Read();


                    if (product != null)
                    {
                        Console.WriteLine("按下任意键删除 {0}-{1} ", product.Id, product.Name);
                        Console.ReadLine();
                        context.Product.Remove(product);
                        int rowCount = context.SaveChanges();
                        Console.WriteLine("成功删除 {0} 项数据 !", rowCount);
                    }
                    else
                    {
                        Console.WriteLine("找不到编号 {0} 的数据 !", id);
                    }
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n错误信息：{0}\n", ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}