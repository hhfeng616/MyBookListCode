using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LToLookup
{
    class OToLookup
    {

        public static void ToLookup()
        {
            using (var context = new KTStoreModel())
            {

                IQueryable<Product> products =
                   from product in context.Products
                   select product;

                ILookup<string, Product> look =
                    products.ToLookup(
                        key => key.Category
                    );
                foreach (IGrouping<string, Product> group in look)
                {
                    Console.WriteLine("\n{0}", group.Key);

                    foreach (Product product in group)
                    {
                        Console.WriteLine("　{0}\t{1}",
                            product.Id, 
                            product.Name );
                    }
                }
            }
        }
    }
}
