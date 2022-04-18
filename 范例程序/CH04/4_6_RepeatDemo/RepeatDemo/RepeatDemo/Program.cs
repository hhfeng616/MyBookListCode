using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string> enumerable =
                Enumerable.Repeat<string>(
                "www.baidu.com", 5);
            foreach (var str in enumerable)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();

        }
    }
}
