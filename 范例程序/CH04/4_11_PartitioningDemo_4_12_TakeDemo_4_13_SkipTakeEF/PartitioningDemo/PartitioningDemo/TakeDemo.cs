using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningDemo
{
    class TakeDemo
    {
        public static void DoTake() {

            List<int> intList =
                new List<int> { 1, 2, 3, 4, -5, 6, 7, 8, 9, 0 };
            Console.WriteLine("原始集合内容:");
            foreach (int i in intList)
                Console.Write(i + ",");

            IEnumerable<int> intListSkip = intList.Take(5);
            Console.WriteLine("\nTake 之后的集合内容:");
            foreach (int i in intListSkip)
                Console.Write(i + ",");

            intListSkip =
                intList.TakeWhile(iNumber => iNumber < 6);
            Console.WriteLine("\nTakeWhile 之后的集合内容:");
            foreach (int i in intListSkip)
                Console.Write(i + ",");

            intListSkip = intList.TakeWhile(
                (iNumber, index) => iNumber > index);
            Console.WriteLine("\nTakeWhile 之后的集合内容:");
            foreach (int i in intListSkip)
                Console.Write(i + ",");

        }
    }
}
