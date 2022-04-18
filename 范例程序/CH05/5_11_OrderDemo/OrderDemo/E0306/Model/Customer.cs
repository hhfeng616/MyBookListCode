using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E0306.Model
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

