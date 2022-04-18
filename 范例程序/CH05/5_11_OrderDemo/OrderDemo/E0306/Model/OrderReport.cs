using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E0306.Model
{
    public class OrderReport
    {
        public int Id { get;set;}
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }

        public string ProductName { get; set; }
        public int OPrice { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public int Sum { get; set; }
    }
}

