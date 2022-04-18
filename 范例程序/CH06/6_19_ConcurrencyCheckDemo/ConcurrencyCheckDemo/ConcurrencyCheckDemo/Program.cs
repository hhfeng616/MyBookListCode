using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyCheckDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                KTStoreModel model = new KTStoreModel();
                //int c = model.Products.Count();
                //Console.WriteLine(c);

                Console.WriteLine("指定更新操作：A.商品名称　B.商品特价");
                string ab = Console.ReadLine();
                if (ab == "A")
                {
                    Console.WriteLine("输入第一项商品的新名称：");
                    string name = Console.ReadLine();
                    model.Product.First().Name = name;
                }
                if (ab == "B")
                {
                    Console.WriteLine("输入第一项商品的新特价：");
                    int sprice = int.Parse(Console.ReadLine());
                    model.Product.First().SPrice = sprice;
                }


                Console.WriteLine("按任意键完成更新 …");
                Console.ReadKey();
                model.SaveChanges();
                Console.WriteLine("完成更新 !");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}