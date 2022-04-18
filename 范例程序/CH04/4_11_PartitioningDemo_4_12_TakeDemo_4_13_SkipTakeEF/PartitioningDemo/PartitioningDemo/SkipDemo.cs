using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningDemo
{
    class SkipDemo
    {
        public static void DoSkip()
        {



            // 
            List<int> intList =
                new List<int> { 1, 2, 3, 4, -5, 6, 7, 8, 9, 0 };
            IEnumerable<int> intListSkip =
                intList.SkipWhile(
                    (iNumber, index) => iNumber > index);



            //List<int> intList =
            //    new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ////IEnumerable<int> intListSkip = intList.Skip(5);

            //IEnumerable<int> intListSkip =
            //    intList.SkipWhile(iNumber => iNumber < 5);


            Console.WriteLine("原始集合内容：");
            foreach (int i in intList)
                Console.Write("{0}　", i);

            Console.WriteLine("\nSkip 5个位置之后的集合内容:");
            foreach (int i in intListSkip)
                Console.Write("{0}　", i);
        }
    }
}
