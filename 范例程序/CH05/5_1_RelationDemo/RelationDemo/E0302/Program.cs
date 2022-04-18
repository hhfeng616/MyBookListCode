using E0302.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E0302
{
    class Program
    {
        static void Main(string[] args)
        {

            KTStoreEntities entity = new KTStoreEntities();
            IEnumerable<Category> categories = from category in entity.Category
                                               select category;
            foreach (Category category in categories)
            {
                Console.WriteLine(category.Name);
                foreach (Product product in category.Product)
                {
                    Console.WriteLine('\t' + product.Name);
                }
            }
            Console.ReadKey();
            Console.WriteLine('\t');

            IEnumerable<Product> products = from product in entity.Product
                                            select product;
            foreach (Product product in products)
            {
                Console.WriteLine(product.Category.Name.ToString() + '\t'+ product.Name );
               
                
                

            }
            Console.ReadKey();


            

        }
    }
}


