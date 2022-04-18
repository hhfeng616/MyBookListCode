using E0303.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E0303
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreEntities entity = new KTStoreEntities();

            IEnumerable<Product>  products = from product in entity.Product
                                             where product.CategoryId == 1
                                             select product;
            foreach (Product product in products) {
                Console.WriteLine("{0}\nISBN:{1}\t页数:{2}\t作者:{3}\n",    
                    product.Name, 
                    product.Book.ISBN,
                    product.Book.Pages, 
                    product.Book.Author );
            }
            Console.ReadKey() ;
        }
    }
}
