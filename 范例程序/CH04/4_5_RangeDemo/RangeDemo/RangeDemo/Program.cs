using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            IEnumerable<int> enumNumber = Enumerable.Range(1, 10);
            program.ShowEnum("原始集合序列", enumNumber);
            enumNumber =
               Enumerable.Range(1, 10).Select(x => x * 2 + 1);
            program.ShowEnum("奇数集合序列", enumNumber);
            enumNumber =
               Enumerable.Range(1, 10).Select(x => x * 2);
            program.ShowEnum("偶数集合序列", enumNumber);
            Console.ReadKey();
        }
        private void ShowEnum(string str,
                IEnumerable<int> enumNumber)
        {
            Console.WriteLine(str);
            foreach (int i in enumNumber)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }

    }
}
