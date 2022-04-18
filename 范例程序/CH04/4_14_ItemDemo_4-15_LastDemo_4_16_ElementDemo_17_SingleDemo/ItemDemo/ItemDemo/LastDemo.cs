using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDemo
{
    class LastDemo
    {
        public static void DoLast()
        {
            List<int> intList = new List<int> {
                1, 2, 3, 4, -5, 6, 7, 8, 9, 0 };

            int firstValue = intList.Last(
                intElement => intElement % 2 == 0);
            Console.WriteLine(
                "intList集合序列的最后一个偶数：" +
                firstValue.ToString());

            firstValue = intList.LastOrDefault(
                intElement => intElement % 2 != 0);
            Console.WriteLine(
                "intList集合序列的最后一个奇数：" +
                firstValue.ToString());

            IEnumerable<int> enumObject = Enumerable.Empty<int>();
            firstValue = enumObject.LastOrDefault(
                intElement => intElement % 2 != 0);
            Console.WriteLine(
                "enumObject集合序列的第一个奇数（空值）：" +
                firstValue.ToString());
        }

    }
}
