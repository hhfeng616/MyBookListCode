using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E0306.Model
{
    public class KTStoreModel : DbContext        
    {
        public KTStoreModel() : 
            base("name=KTStoreModelConn")
        {
        }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<
                System.Data.Entity.ModelConfiguration.Conventions.
                PluralizingTableNameConvention>();
        }
    }
}
