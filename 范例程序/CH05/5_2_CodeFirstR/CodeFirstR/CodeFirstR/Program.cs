using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstR.Model;

namespace CodeFirstR
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new KTStoreModel())
            {
                IEnumerable<Category> categories = from category in context.Categories
                                                   select category;

                foreach (Category category in categories)
                {
                    Console.WriteLine(category.Name);
                    foreach (Product product in category.Products)
                    {
                        Console.WriteLine('\t' + product.Name);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
