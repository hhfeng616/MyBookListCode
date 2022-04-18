namespace CodeFirstM
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

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Book)
                .WithMany(e => e.Author)
                .Map(m => m.ToTable("BookAuthor").MapLeftKey("AuthorId").MapRightKey("BookId"));
        }
    }
}
