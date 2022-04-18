namespace ConventionDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class KTStoreModel : DbContext
    {
        // 您的内容已设置为使用应用程序配置文件（App.config 或 Web.config）
        // 中的 'KTStoreModel' 连接字符串。根据默认，这个连接字符串的目标是
        // 您的 LocalDb 实例上的 'ConventionDemo.KTStoreModel' 数据库。
        // 
        // 如果您的目标是其他数据库和 (或) 提供者，请修改
        // 应用程序配置文件中的 'KTStoreModel' 连接字符串。
        public KTStoreModel()
            : base("name=KTStoreModel")
        {
        }

        // 针对您要包含在模型中的每种实体类型添加 DbSet。如需有关设置和使用
        // Code First 模型的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }

    // Order
    [Table("Order")]
    public partial class Order
    {
        // 主键
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        // 导航属性
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    // OrderDetail
    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        // 主键
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int XOrderId { get; set; }
        // 导览属性
        [ForeignKey("XOrderId")]
        public virtual Order Order { get; set; }
    }

}