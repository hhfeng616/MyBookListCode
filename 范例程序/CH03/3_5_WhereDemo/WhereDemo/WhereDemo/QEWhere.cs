using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereDemo
{
    class QEWhere
    {
        public static void DoWhere()
        {
            int[] numberQuery = {
                   123,456,789,100,365,7,24 };
            IEnumerable<int> enumNumbers =
                from number in numberQuery
                where number <= 300 && number >= 100
                select number;
            string source = "原始数字:";
            foreach (int number in numberQuery)
            {
                source += number + ",";
            }
            Console.WriteLine(source);
            string result = "查询结果(100-300间的数字):";
            foreach (int number in enumNumbers)
            {
                result += number + ",";
            }
            Console.WriteLine(result);
            enumNumbers =
                from number in numberQuery
                where CheckEven(number)
                select number;

            result = "查询结果(偶数):";
            foreach (int number in enumNumbers)
            {
                result += number + ",";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static bool CheckEven(int nvalue)
        {
            bool returnValue = (nvalue % 2 == 0);
            return returnValue;
        }



    }
}
