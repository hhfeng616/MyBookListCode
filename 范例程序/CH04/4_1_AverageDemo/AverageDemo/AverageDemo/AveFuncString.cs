using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageDemo
{
    class AveFuncString
    {
        public static void DoAveFunc()
        {
            List<string> list = new List<string>
                    {
                    "microsoft","yahoo","google","eBay",
                    "amazon","msn","youtube","flickr"
                    };
            double averageValue =list.Average(str => str.Length);          
          
            foreach (string s in list)
            {
                Console.Write("{0}　", s);
            }            
            Console.WriteLine("字符串长度的平均值是：" +averageValue);
            Console.ReadKey();


        }
    }
}
