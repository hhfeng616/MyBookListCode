using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAsEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            SPList<Product> products =new SPList<Product> {
                    new Product() {Id=1000,Name="BOOKX01",Price=90,Category="Book" }  ,
                    new Product() {Id=1001,Name="BOOKX02",Price=70,Category="Book" }  ,
                    new Product() {Id=1002,Name="BOOKX03",Price=80,Category="Book" }
                };
            Console.WriteLine( products.Average(p=>p.Price)) ;
            Console.WriteLine(products.AsEnumerable().Average(p => p.Price));




            TableAsE.TableAsEnumerable();







            Console.Read();         
        }
        class SPList<T> : List<T>
        {
            public decimal Average(Func<T, decimal> s)
            {
                var list = (List<T>)this;             
                decimal price = list.Average(s) * Decimal.Parse("0.8");
                return price;
            }

        }
    }    
}
