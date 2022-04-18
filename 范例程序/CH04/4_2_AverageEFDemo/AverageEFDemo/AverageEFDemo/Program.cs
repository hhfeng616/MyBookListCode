using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageEFDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var context = new KTStoreModel())
            {


                AggDemo.DoAgg();


                //IQueryable<int> prices = from p in context.Products
                //                         select p.Price;
                //double average = prices.Average();


                //double average = context.Products.Average(p=>p.Price);
                //Console.WriteLine("商品平均价格：{0}",average);
                
                Console.Read();


            }



        }
    }
}
