using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E0305.Model;
namespace E0305
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreEntities entity = new KTStoreEntities();
            IEnumerable<Order> orders = from order in entity.Order
                                        select order;
            foreach (Order order in orders) {
                Console.WriteLine("订单编号：{0}\t日期：{1}\n", order.Id, order.OrderDate);           
                foreach (OrderDetail orderDetail in order.OrderDetail) {
                    Console.WriteLine("\t商品：{0}　数量：{1}　单价：{2}　小计：{3}　",
                        orderDetail.Product.Name,
                        orderDetail.Quantity ,orderDetail.Price,
                        orderDetail.Quantity*orderDetail.Price);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

