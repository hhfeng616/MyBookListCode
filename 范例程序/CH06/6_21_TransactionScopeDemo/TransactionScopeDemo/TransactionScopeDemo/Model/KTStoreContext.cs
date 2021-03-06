using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionScopeDemo.Model
{
    public class KTStoreContext : DbContext
    {
        public KTStoreContext() : base("name=KTStoreModelConn"){}
        public KTStoreContext(DbConnection existingConnection, bool contextOwnsConnection) : 
            base(existingConnection, contextOwnsConnection) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
        public virtual DbSet<Product> Products { get; set; }
    }

}
