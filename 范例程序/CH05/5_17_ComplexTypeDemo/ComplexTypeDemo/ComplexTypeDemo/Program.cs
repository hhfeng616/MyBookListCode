using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexTypeDemo.Model;
namespace ComplexTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreModel model = new KTStoreModel(); foreach (Product product in model.Products)
            {
                Console.WriteLine("{0} 价格：{1}", product.Name, product.Price);
                if (product.Book.ISBN != null)
                {
                    Console.WriteLine("\t{0} ISBN：{1} 作者：{2} 页数：{3}", product.Book.Title,
                    product.Book.ISBN, product.Book.Author, product.Book.Pages);
                }
                else
                {
                    Console.WriteLine("\t 非书籍数据");
                }


                /*
                using (var model = new KTStoreModel())
                {

                    Console.Write("\n按序输入 商品名称,价格：");
                    string info = Console.ReadLine();
                    string[] infos = info.Split(',');

                    Product product = new Product
                    {
                        Name = infos[0],
                        Price = int.Parse(infos[1]),
                        Book = new Book()
                    };
                    Console.Write("\n是否为书籍数据，是（Y）：");
                    if (Console.ReadLine() == "Y")
                    {
                        Console.Write("\n按序输入 Title,ISBN,Author,Pages：");
                        string book_info = Console.ReadLine();
                        string[] book_infos = book_info.Split(',');
                        product.Book.Title = book_infos[0];
                        product.Book.ISBN = book_infos[1];
                        product.Book.Author = book_infos[2];
                        product.Book.Pages = int.Parse(book_infos[3]);
                    }
                    model.Products.Add(product);
                    model.SaveChanges();
                }
                */
                Console.ReadKey();
            }
        }
    }
}