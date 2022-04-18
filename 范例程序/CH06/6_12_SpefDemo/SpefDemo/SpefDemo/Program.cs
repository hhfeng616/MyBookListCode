using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpefDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Part I
            using (var entity = new KTStoreEntities())
            {
                ObjectResult<ProductList_Result> products = entity.ProductList() ;

                foreach (ProductList_Result product in products)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadLine();
            }
            */

            /*  Part II  */
            using (var entity = new KTStoreEntities())
            {
                ObjectResult<GetProductByName_Result> products = entity.GetProductByName("ASP.NET");

                foreach (GetProductByName_Result product in products)
                {
                    Console.WriteLine(product.Name);
                }
               
            }

            using (var entity = new KTStoreEntities())
            {
                int c =entity.SetSPriceById(100,2);
                Console.WriteLine("变更项数：{0}",c);
            }
          



            Console.ReadLine();
        }

    }
}
