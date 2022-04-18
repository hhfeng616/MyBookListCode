using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifierDemo
{
    class AnyDemo
    {
        public static void DoAny()
        {
            IEnumerable<String> enumerable = Enumerable.Empty<string>();
            bool anyBool = enumerable.Any();
            if (anyBool == false)
                Console.WriteLine("enumerable集合内容是 空值…");
            else
                Console.WriteLine("enumerable集合内容非 空值…");
            Console.ReadKey();
        }
    }
}
