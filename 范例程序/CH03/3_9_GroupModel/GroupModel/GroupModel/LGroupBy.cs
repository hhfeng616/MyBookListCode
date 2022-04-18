
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupModel
{
    class LGroupBy
    {
        public static void Group()
        {
            using (var context = new KTStoreModel())
            {
               
                IEnumerable<IGrouping<int, Product>> groups =
                   from product in context.Products.ToList()
                   group product by CheckPrice(product.Price);


                foreach (IGrouping<int, Product> group in groups)
                {
                    string message = "";

                    if (group.Key == 300)
                        message = "\n高价　> 200\n";
                    else if (group.Key == 200)
                        message = "\n中价　101 - 200\n";
                    else
                        message = "\n低价　< 100 \n";

                    Console.WriteLine(message);

                    foreach (Product product in group)
                    {
                        Console.WriteLine("　价格：{1}\t{0}",
                            product.Name, product.Price);
                    }
                }
            }
        }

        static int CheckPrice(int price)
        {
            if (price > 200)
                return 300; 
            else if(price >= 100 && price <= 200)
                return 200;
            else
                return 100;

        }
    }
}
