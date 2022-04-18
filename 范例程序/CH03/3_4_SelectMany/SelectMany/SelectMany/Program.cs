using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {

            LSelectMany.SMDemo();
            LSelectManyBook.SMDemo();

            //string[] weekMonth = {
            //    "JANUARY,FEBRUARY,MARCH,APRIL,MAY,JUNE,JULY,AUGUST,SEPTEMBER,OCTOBER,NOVEMBER,DECEMBER",
            //    "Monday,Tusday,Wednesday,Thursday,Friday,Saturday,Sunday" };

            //IEnumerable<string> enumWeekMonth = from wm in weekMonth
            //                                    from daywm in wm.Split(',')
            //                                    select daywm.Substring(0, 3);

            //string weekDayOutput ="一星期七天与一年十二个月的英文全名:\n";
            //foreach (string dayweekmonth in weekMonth)
            //{
            //    weekDayOutput += dayweekmonth + "\n";
            //}
            //Console.WriteLine(weekDayOutput);

            //weekDayOutput = "一星期七天与一年十二个月的英文全名缩写:\n";
            //foreach (string dayweekmonth in enumWeekMonth)
            //{
            //    weekDayOutput += dayweekmonth + "\n";
            //}
            //Console.WriteLine(weekDayOutput);

            Console.ReadLine();

        }
    }
}
