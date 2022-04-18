using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawSQLCommand.Model
{
    public class KTStoreContext : DbContext
    {
        public KTStoreContext() : base("name=KTStoreModelConn"){}     

        public virtual DbSet<Product> Products { get; set; }
    }

}


