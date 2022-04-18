namespace CFMigrations
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KTStoreModel : DbContext
    {
        public KTStoreModel()
            : base("name=KTStoreModelConn")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}
