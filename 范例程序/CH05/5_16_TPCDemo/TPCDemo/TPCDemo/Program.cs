using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCDemo.Model;
namespace TPCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreModel model = new KTStoreModel();
            int c=model.Products.Count();
            foreach(var product in model.Products.OfType<Book>())
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}


