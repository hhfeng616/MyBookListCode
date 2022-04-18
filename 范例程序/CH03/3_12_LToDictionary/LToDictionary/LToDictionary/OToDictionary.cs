using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LToDictionary
{
    class OToDictionary
    {
        public static void ToDictionary() {

            using (var context = new KTStoreModel()) {

                IQueryable<Product> products = 
                    from product in context.Products
                    select product;

                //Dictionary<string, Product> directory = 
                //    products.ToDictionary(
                //        key => key.Category + "_" + key.Id
                //    );
                //foreach(KeyValuePair<string ,Product> key in directory)
                //{
                //    Console.WriteLine("{0}\t{1}", 
                //        key.Key, key.Value.Name);
                //}
                Dictionary<string, string> directory =
                    products.ToDictionary(
                        key => key.Category + "_" + key.Id,
                        key => key.Id+"_"+key.Name 
                    );
                foreach (KeyValuePair<string, string> key in directory)
                {
                    Console.WriteLine("{0}\t{1}",
                        key.Key, key.Value);
                }

            }
        }
    }
}
