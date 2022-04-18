using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E0306.Model;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace E0306
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreModel model = new KTStoreModel();
            int c = model.Orders.Count();
            Console.WriteLine(c);

            var orderlist = from orderDetail in model.OrderDetails
                            join order in model.Orders on
                            orderDetail.OrderId equals order.Id
                            select new { orderDetail,order };

            foreach (var odetail in orderlist) {

                string id  =odetail.order.Id.ToString();
                string product = odetail.orderDetail.Product.Name;
                Console.WriteLine("订单编号：{0}－订购商品　{1}", id,product);
            }

            IEnumerable<OrderReport> report = from orderDetail in model.OrderDetails
                            join order in model.Orders on
                            orderDetail.OrderId equals order.Id
                            select new OrderReport{

                                Id=order.Id,
                                CustomerName = order.Customer.ContactName  ,

                                 OrderDate = order.OrderDate,
                                 ProductName = orderDetail.Product.Name,
                                 OPrice  = orderDetail.Price,
                                 Price  =  orderDetail.Product.Price,
                                 Quantity = orderDetail.Quantity,
                                 Sum = orderDetail.Price * orderDetail.Quantity 

                            };

            foreach (var order in report)
            {
                Console.WriteLine("{0}　{1}\t{2}　订价：{3}\t单价：{4}　数量：{5}　小计：{5}",
                    order.Id,
                    order.OrderDate.ToShortDateString(),
                    order.ProductName,
                    order.Price,
                    order.OPrice,
                    order.Quantity,
                    order.Sum);
            }

            int total = report.Sum(o => o.Sum) ;

            Console.WriteLine("\n总金额：￥ {0} 元整", total.ToString("0,0"));



            // var query =(ObjectQuery<OrderReport>)report ;
            string sql = report.ToString() ;
            Console.WriteLine(sql);

           Console.ReadKey();
        }
    }
}
