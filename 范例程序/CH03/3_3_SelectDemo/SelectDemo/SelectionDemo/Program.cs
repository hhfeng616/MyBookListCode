using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        //    using (var context = new KTStoreModel())
        //    {
        //        IQueryable<Product> products =
        //            from product in context.Products
        //            select product;
        //        foreach (var product in products)
        //        {
        //            Console.WriteLine("分类：{0}\t价格：{1}\t{2}\t{3}\t",
        //                 product.Category, product.Price, product.Id, product.Name);
        //        }
        //    }
            SelectShap.shap();
            Console.Read();

        }
    }
}
