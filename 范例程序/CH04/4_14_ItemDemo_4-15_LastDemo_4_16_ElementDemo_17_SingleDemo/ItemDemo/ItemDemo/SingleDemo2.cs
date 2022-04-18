using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDemo
{
    class SingleDemo2
    {

        public static void DoSingle()
        {

            List<string> weekDays =
                new List<string> { "www.baidu.com" };
            foreach (string str in weekDays)
            {
                Console.WriteLine(
                "原始字符串：" + str);
            }
            string elementSingle =
                weekDays.SingleOrDefault(
                str => str.Substring(4, 5) == "baidu");
            Console.WriteLine(
                "元素的第五个字符开始的五个字符等于 baidu：" +
                elementSingle);
            elementSingle =
                weekDays.SingleOrDefault(
                str => str.Substring(0, 3) == "wwk");
            Console.WriteLine(
                "元素的第一个字符开始的三个字符等于 wwk：" +
                elementSingle);

        }
    }
}
