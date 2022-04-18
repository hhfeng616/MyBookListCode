using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace TPTDemo.Model
{
    public class KTStoreModel : DbContext
    {
        public KTStoreModel() :
            base("name=KTStoreModelConn")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
