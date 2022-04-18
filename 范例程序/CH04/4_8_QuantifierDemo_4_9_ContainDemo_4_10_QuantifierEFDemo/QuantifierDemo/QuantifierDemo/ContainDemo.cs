using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifierDemo
{
    class ContainDemo
    {
        public static void DoContain() {

            List<string> list =
               new List<string> {"Mon", "Tue", "Wed", "Thu","Fri","Sat","Sun"};

            Console.WriteLine("输入核对字符串：");
            string s = Console.ReadLine();
            bool b = list.Contains(s);
            string result = "";
            if (b == true)
            {
                result = "包含";
            }
            else {
                result = "不包含"; 
            }
            Console.WriteLine("List 集合中{0}核对字符串「{1}」",result, s);
            Console.ReadKey();

        }
    }
}
