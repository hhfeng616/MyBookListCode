
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupModel
{
    class LGroupInto
    {

        public static void GroupInto() {


            using (var context = new KTStoreModel())
            {
                IEnumerable<IGrouping<string, Product>> groups =
                    from product in context.Products
                    group product by product.Category into cgroup
                    orderby cgroup.Key descending
                    select cgroup ;

                foreach (IGrouping<string, Product> group in groups)
                {
                    Console.WriteLine(group.Key);
                    foreach (Product product in group)
                    {
                        Console.WriteLine("\t{0}\t价格：{1}",
                            product.Name, product.Price);
                    }
                }
            }

        }
    }
}
