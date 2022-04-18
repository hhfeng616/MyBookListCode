using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToArrayList
{
    class LToArray
    {
        public static void ToArray()
        {
            using (var context = new KTStoreModel())
            {
                string[] list = (from product in context.Products 
                           select product.Name).ToArray();

                for (int i = 0; i < list.Length; i++) {

                    Console.WriteLine(list[i]);
                }                
            }
        }
    }
}
