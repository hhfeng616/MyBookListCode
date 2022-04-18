namespace FluentApiDemo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class KTStoreModel : DbContext
    {
        public KTStoreModel()
            : base("name=KTStoreModel")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Product>().ToTable("tbProduct", "kt");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Product>().HasKey(p => p.XPId);
            modelBuilder.Entity<Product>().Property(p => p.Name)
               .HasColumnName("ProductName");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Price)
                .HasColumnName("ProductPrice");
            modelBuilder.Entity<Product>().Ignore(p => p.SPrice);
        }
    }   
}

