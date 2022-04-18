namespace SaveChangesDemo.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Validation;
    using System.Data.Entity.Infrastructure;
    using System.Collections.Generic;
    public partial class KTStoreContext : DbContext
    {
        public KTStoreContext()
            : base("name=KTStoreModelConn")
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        protected override DbEntityValidationResult ValidateEntity(
            DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            var list = new List<DbValidationError>();
            if (entityEntry.CurrentValues.GetValue<string>("Name")==null ||
                entityEntry.CurrentValues.GetValue<string>("Name").Length <4    )
            {                
                list.Add(new DbValidationError("Name", "商品名称必须多于四个字符"));                
            }
            if (entityEntry.CurrentValues.GetValue<int>("Price") <0 )
            {
                list.Add(new DbValidationError("Price", "商品价格不得小于0"));
            }
            if (entityEntry.CurrentValues.GetValue<int>("SPrice") < 0)
            {
                list.Add(new DbValidationError("SPrice", "商品价格不得小于0"));
            }
            if (list.Count() > 0)
            {
                return new DbEntityValidationResult(entityEntry, list);
            }
            else
                return base.ValidateEntity(entityEntry, items);
        }


        /*
        public override int SaveChanges()
        {
            try {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message ;

                if (ex is DbEntityValidationException)
                {

                    message = "验证异常\n"; 
                    foreach (var validationResult in (
                        (DbEntityValidationException)ex).EntityValidationErrors)
                    {                       
                        foreach (var error in validationResult.ValidationErrors)
                        {
                            message += ("  " + error.ErrorMessage+ "\n");                          
                        }
                    }
                }
                throw new Exception(message) ;
            }

        }
        */
    }
}
