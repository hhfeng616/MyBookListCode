using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHDemo.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class Book : Product
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }

    public class Magazine : Product
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string ISSN { get; set; }
        public int MPages { get; set; }

    }
}
