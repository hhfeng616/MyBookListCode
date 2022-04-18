using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfTypeDemo
{
    class OfTypeM
    {
        public static void DoOfType() {

            using (var context = new KTStoreModel())
            {
                var products = from product in context.Products.ToList()
                               select GetSProduct(product);

                IEnumerable<XBook> books = products.OfType<XBook>();
                foreach (XBook bbx in books)
                {
                    Console.WriteLine("{0}\tISBN:{1}", bbx.Name, bbx.ISBN);
                }                
            }
            
        }
        static object GetSProduct(Product p)
        {
            if (p.Category == "Book")
            {
                XBook b = new XBook()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ISBN = "000-000-000-000-0",
                    Category = "图书"
                };
                return b;
            }
            else
            {
                return p;
            }
        }
    }
    public class XBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
    }
}
