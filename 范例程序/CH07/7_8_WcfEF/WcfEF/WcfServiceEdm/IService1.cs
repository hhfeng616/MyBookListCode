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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Product ProductList(int id);
        [OperationContract]
        IEnumerable<Product> ProductAll();

        [OperationContract]
        ProductSPrice ProductSpriceList(int id);
        [OperationContract]
        IEnumerable<ProductSPrice> ProductSpriceAll();
    }


    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    [DataContract]
    public class ProductSPrice
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string IdName { get; set; }
        [DataMember]
        public string SPrice { get; set;  }
    }

    [DataContract]
    public class CompositeType
    {


        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }



    }
}
