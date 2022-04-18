using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifierDemo
{
    class QuantifierEFDemo
    {
        public static void DoQuantifier() {
            using (var context = new KTStoreModel()) {

                IEnumerable<Product> products =
                    context.Products.Where(p => p.Category == "Book"); 

                bool b = products.All(p => p.Price <= 100);
                if (b)
                    Console.WriteLine("所有书籍订价 100 元以下 !");
                else
                    Console.WriteLine("所有书籍订价高于 100 !");
            }
        }
    }
}
