using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> monthList = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //IEnumerable<IGrouping<int, int>> query =
            //    from month in monthList
            //    group month by checkMonth(month);


            //IEnumerable<IGrouping<int, int>> query =
            //    from month in monthList
            //    group month by checkMonth(month) into o
            //    orderby o.Key
            //    select o;



            //IEnumerable<IGrouping<int, int>> query = 
            //    monthList.GroupBy(month => checkMonth(month));

            IEnumerable<IGrouping<int, int>> query =
                monthList.GroupBy(month => checkMonth(month))
                .Select(g=>g).OrderBy(g=>g.Key)
                ;




            foreach (var group in query)
            {
                Console.WriteLine(
                    group.Key > 30 ? "\n大月:" : "\n小月:");
                foreach (int i in group)
                    Console.Write(
                        i + "-" + group.Key.ToString() + " ");
            }
            Console.ReadLine();
        }
        private static int checkMonth(int month)
        {
            int resultDays;
            resultDays = DateTime.DaysInMonth(2008, month);
            return resultDays;
        }

    }
}
