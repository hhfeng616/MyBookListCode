using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPCDemo.Model
{
    public class KTStoreModel : DbContext
    {
        public KTStoreModel() :
            base("name=KTStoreModelConn")
        {
        }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .Property(c => c.PID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); 


            modelBuilder.Entity<Book>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Book");
            });
            modelBuilder.Entity<Magazine>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Magazine");
            });
        }
    }
}
