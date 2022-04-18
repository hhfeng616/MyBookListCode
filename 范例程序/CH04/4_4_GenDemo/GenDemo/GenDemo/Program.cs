using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> enumerable = Enumerable.Empty<string>();
            int c = enumerable.Count();
            Console.WriteLine("元素数量：{0}",c);


            IEnumerable<string> enumone = Enumerable.DefaultIfEmpty(enumerable);       

            c = enumone.Count();
            Console.WriteLine("enumone 元素数量：{0}", c);

            foreach (var s in enumone) {

                Console.WriteLine("{0}",  string.IsNullOrEmpty(s));
            }


            IEnumerable<string> enumoned = Enumerable.DefaultIfEmpty(enumerable,"SUN");
            Console.WriteLine("enumone 元素数量：{0}", c);

            foreach (var s in enumoned)
            {
                Console.WriteLine("{0}", string.IsNullOrEmpty(s));
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
