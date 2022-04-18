using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDemo
{
    class Program
    {
        static void Main(string[] args)
        {



            LoadDemo.LocalLoad();


            /*
            using (var context = new KTStoreModel()) {

                var local = context.Product.Local;
                Console.WriteLine("Local:{0}",local.Count());

                foreach(Product p in context.Product)
                {
                    // Query 
                }
                Console.WriteLine("Query-Local:{0}", local.Count());

                context.Product.Add(new Product {
                    Id = 1001,
                    Name = "Android III",
                    Price = 100 });

                Console.WriteLine("Add-Locl:{0}", local.Count());


                foreach (Product p in context.Product)
                {
                    Console.WriteLine("Query:{0}" ,p.Name);

                }


                foreach (Product p in local)
                {
                    Console.WriteLine("Local:{0}", p.Name);

                }
            
                Console.ReadLine();
            }

    */
        }
    }
}
