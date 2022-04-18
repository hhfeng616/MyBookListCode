using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TimStampDemo.Model
{
    public class KTStoreModel:DbContext
    {
        public KTStoreModel()
            : base("name=KTStoreConn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<
                System.Data.Entity.ModelConfiguration.Conventions.
                PluralizingTableNameConvention>();
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
