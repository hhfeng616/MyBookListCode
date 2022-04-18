using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageDemo
{
    class AveFuncDemo
    {
        public static void DoAveFunc()
        {
            List<double> list = new List<double>
            {
                1.1,2.2,3.3,4.4,5.5,6.6,7.7,8.8,9.9,10
            };
            double averageValue = list.Average(x => x * 100);

            foreach (double i in list)
            {
                Console.Write("{0}　", i);
            }
            Console.Write("\t平均值：{0}", averageValue);
        }
    }
}
