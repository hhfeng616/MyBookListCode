using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LToLookup
{
    class Program
    {
        static void Main(string[] args)
        {


            OToLookup.ToLookup();


            //List<string> listBooks = new List<string>
            //{
            //        "ASP.NET MVC 入门" ,
            //        "React 实践" ,
            //        "Entity Framework 实用精解" ,
            //        "前端开发完全入门" ,
            //        "ASP.NET 专业开发"
            //};
            //int i = 0;
            //ILookup<string, string> lookup =
            //    listBooks.ToLookup(key => "book" );
            //foreach (IGrouping<string, string> igp in lookup)
            //{
            //    Console.WriteLine("{0}" , igp.Key );
            //    foreach (string str in igp)
            //        Console.WriteLine("　" + str);
            //}
            Console.ReadKey();

        }
    }
}
