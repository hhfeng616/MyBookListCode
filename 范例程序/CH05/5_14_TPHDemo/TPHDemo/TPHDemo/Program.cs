using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHDemo.Model;

namespace TPHDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreModel model = new KTStoreModel();
            /* var products = model.Products;
            foreach (Product product in model.Products) {
                Console.WriteLine(product.Name);               
            } */

            
            while (true)
            {
                Console.Write("\n1.图书　2.杂志　");
                int i = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    Console.Write("\n按序输入 书名,价格,页数,ISBN,作者：");
                    string info = Console.ReadLine();
                    string[] infos = info.Split(',');

                    Product book = new Book
                    {
                        Name = "图书-" + infos[0],
                        Title = infos[0],
                        Price = int.Parse(infos[1]),
                        Pages = int.Parse(infos[2]),
                        ISBN = infos[3],
                        Author = infos[4]
                    };
                    model.Products.Add(book);
                    model.SaveChanges();
                }
                else if (i == 2)
                {
                    Console.Write("\n按序输入 杂志名称,价格,页数,ISSN,年份,月：");
                    string info = Console.ReadLine();
                    string[] infos = info.Split(',');

                    Product magazine = new Magazine
                    {
                        Name = "杂志-" + infos[0],
                        Price = int.Parse(infos[1]),
                        MPages = int.Parse(infos[2]),
                        ISSN = infos[3],
                        Year = int.Parse(infos[4]),
                        Month = int.Parse(infos[5])
                    };
                    model.Products.Add(magazine);
                    model.SaveChanges();
                }
                else
                {
                    break;
                }
            }
            int c = model.Products.Count();
            Console.WriteLine("当前数据项数：{0}", c);
            
            Console.ReadKey();
        }
    }
}