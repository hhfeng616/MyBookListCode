using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceEdm.Model;
namespace WcfServiceEdm
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
        public Product ProductList(int id)
        {
            return (new KTStoreContext()).Products.Find(id);
        }
        public IEnumerable<Product> ProductAll() {
            return (new KTStoreContext()).Products.ToList();
        }


        public ProductSPrice ProductSpriceList(int id)
        {
            Product product = (new KTStoreContext()).Products.Find(id);
            string idname = "P_" + product.Id + "_" + product.Name;
            string sprice = product.SPrice + "（ 原价：" + product.Price + " ）";
            ProductSPrice productSPrice = new ProductSPrice
            {
                ID = product.Id,
                IdName = idname,
                SPrice = sprice
            };
            return productSPrice;
        }

        public IEnumerable<ProductSPrice> ProductSpriceAll() {

            IEnumerable<ProductSPrice> products = from p in (new KTStoreContext()).Products
                                                  select new ProductSPrice()
                                                  {
                                                      ID = p.Id,
                                                      IdName = "P_"+p.Id + "_" + p.Name,
                                                      SPrice = p.SPrice + "（ 原价：" + p.Price + " ）"
                                                  };

            return products.ToList();
        } 

        
    }
}

