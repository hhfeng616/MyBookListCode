using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypeDemo.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Book Book{ get; set; }
    }
    public class Book 
    {
        [Column("Title")]
        public string Title { get; set; }
        [Column("ISBN")]
        public string ISBN { get; set; }
        [Column("Author")]
        public string Author { get; set; }
        [Column("Pages")]
        public int? Pages { get; set; }
    }   
}
