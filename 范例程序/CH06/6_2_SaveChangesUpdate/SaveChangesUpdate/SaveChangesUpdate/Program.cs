using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveChangesUpdate.Model;

namespace SaveChangesUpdate
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
                    if (product != null)
                    {
                        Console.Write("{0}:", "更新价格");
                        int price = int.Parse(Console.ReadLine());
                        product.SPrice = price;
                        int rowCount = context.SaveChanges();
                        Console.WriteLine("价格成功更新为 {0} !", price.ToString());
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
                    Console.ReadLine();
                }

            }
        }
    }

}