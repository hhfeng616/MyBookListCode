using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCDemo.Model
{
    public abstract class Product
    {
       [Key]
        public int PID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }    
    public class Book : Product
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
      
    } 
    public class Magazine : Product
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string ISSN { get; set; }  
    }
}
