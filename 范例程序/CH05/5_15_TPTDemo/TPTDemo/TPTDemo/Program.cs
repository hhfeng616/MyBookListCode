using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPTDemo.Model;
namespace TPTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var model = new KTStoreModel())
            {
                        
                var products = model.Products;
                Console.WriteLine("\nBook\n{0}", new String('-', 36));
                foreach (var book in products.OfType<Book>())
                {
                    Console.WriteLine("{0}　页数：{1}　ISBN:{2}　作者：{3}",
                        book.Title,
                        book.Pages,
                        book.ISBN,
                        book.Author);
                }
                Console.WriteLine("\nMagazine\n{0}", new String('-', 36));
                foreach (var magazine in products.OfType<Magazine>())
                {
                    Console.WriteLine("{0}　页数：{1}　ISSN:{2}　年份：{3}　月份：{4}",
                        magazine.Name,
                        magazine.MPages,
                        magazine.ISSN,
                        magazine.Year,
                        magazine.Month);
                }
                int c = model.Products.Count();
                Console.WriteLine("\n总计数据项数：{0}", c);


                /*
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
                */
                Console.ReadLine();
            }
        }
    }
}