using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> listBooks = new List<string>
            //{
            //    "ASP.NET MVC 入门" ,
            //    "React 实践" ,
            //    "Entity Framework 实用精解" ,
            //    "前端开发完全入门" ,
            //    "ASP.NET 专业开发"
            //};
            //int indexValue = 0;
            //Dictionary<string, string> booksDictionary =
            //    listBooks.ToDictionary(
            //    keyValue => "book-" +
            //        (indexValue++).ToString());
            //foreach (KeyValuePair<string, string> kvp
            //    in booksDictionary)
            //{
            //    Console.WriteLine(
            //    "{0}\t{1}", kvp.Key, kvp.Value);
            //}
            //// OToDictionary.ToDictionary();

            OToLookup.ToLookup();
            Console.ReadKey();
        }
    }
}
