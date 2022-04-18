using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {

           // OfTypeM.DoOfType();

            ArrayList al = new ArrayList
                {
                    "Mon","Tue","Wed","Thu","Fri","Sat","Sun",
                    "1","2","3","4","5","6","7",
                    1,2,3,4,5,6,7
                };
            Console.WriteLine("al的原始结果：");
            foreach (Object o in al)
            {
                Console.Write(o.ToString() + ",");
            }
            IEnumerable<String> arrayList = al.OfType<String>();
            IEnumerable<String> strList =
                from strl in arrayList
                select strl;
            Console.WriteLine("\n\nOfType<String>筛选后的结果：");
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }      
    }   
}