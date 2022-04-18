using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDemo
{
    class FirstDemo
    {
        public static void DoFirst() {
            List<int> intList =
            new List<int> { 1, 2, 3, 4, -5, 6, 7, 8, 9, 0 };
            int firstValue = intList.First();
            Console.WriteLine(
                "intList集合序列的第一个元素：" +    firstValue.ToString());
            firstValue = intList.FirstOrDefault();
            Console.WriteLine(
                "intList集合序列的第一元素：" +
                 firstValue.ToString());
            IEnumerable<int> enumObject = Enumerable.Empty<int>();
            firstValue = enumObject.FirstOrDefault();
            Console.WriteLine(
                "enumObject集合序列的第一个元素（空值）：" +
                firstValue.ToString());

        }
    }
}
