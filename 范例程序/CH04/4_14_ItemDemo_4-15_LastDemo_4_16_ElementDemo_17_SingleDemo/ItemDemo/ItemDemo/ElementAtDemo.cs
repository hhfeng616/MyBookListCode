using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDemo
{
    class ElementAtDemo
    {

        public static void DoElementAt() {

            List<string> weekDays =
                new List<string> {
                    "Mon","Tue","Wed","Thu","Fri","Sat","Sun" };
            string elementAt = weekDays.ElementAt(4);
            Console.WriteLine(
                "第五个元素（ElementAt(4)）：" + elementAt);

        }
    }
}
