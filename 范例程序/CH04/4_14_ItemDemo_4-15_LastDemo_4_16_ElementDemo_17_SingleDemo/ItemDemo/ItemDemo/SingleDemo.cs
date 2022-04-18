using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDemo
{
    class SingleDemo
    {
        public static void DoSingle() {
            List<string> baidu =
               new List<string> { "www.baidu.com" };
            string elementSingle = baidu.Single();
            Console.WriteLine(elementSingle);
        }
    }
}
