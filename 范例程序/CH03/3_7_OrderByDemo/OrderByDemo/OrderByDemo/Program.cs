using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByDemo
{
    class Program
    {
        static void Main(string[] args)
        {


              Reverse.DoReverse();


            //using (var context = new KTStoreModel())
            //{
            //    //    //var products =
            //    //    //    from product in context.Products
            //    //    //    orderby product.Price descending
            //    //    //    select product;

            //    //    //var products =
            //    //    // from product in context.Products
            //    //    // orderby product.Category descending, product.Price descending
            //    //    // select product;


            //    var products = context.Products.OrderBy(p => p.Category).ThenByDescending(p => p.Price);


            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("分類：{3}\t价格：{2}\t{0}\t{1}",
            //             product.Id, product.Name, product.Price, product.Category);
            //    }



            //}
            Console.ReadLine();
        }
    }
}
