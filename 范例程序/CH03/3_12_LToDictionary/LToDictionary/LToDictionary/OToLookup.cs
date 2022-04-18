using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LToDictionary
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


                ILookup<string, string> look =
                    products.ToLookup(
                        key => key.Category,
                        key => key.Id+"\t"+key.Name
                    );
                foreach (IGrouping<string, string> group in look)
                {
                    Console.WriteLine("\n{0}", group.Key);

                    foreach (string product in group)
                    {
                        Console.WriteLine("\t{0}", product);
                    }
                }


                //ILookup<string, Product> look =
                //    products.ToLookup(
                //        key => key.Category
                //    );
                //foreach (IGrouping<string, Product> group in look)
                //{
                //    Console.WriteLine("\n{0}", group.Key);

                //    foreach (Product product in group)
                //    {
                //        Console.WriteLine("　{0}\t{1}",
                //            product.Id, 
                //            product.Name );
                //    }
                //}
            }
        }
    }
}
