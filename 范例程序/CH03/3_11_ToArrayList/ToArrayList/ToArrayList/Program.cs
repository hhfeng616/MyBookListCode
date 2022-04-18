using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            // LToList.ToList();

              LToArray.ToArray();
            List<string> weekDay =
            new List<string> {
                "Monday","Tuesday","Wednesday",
                "Thursday","Friday","Saturday","Sunday" };

            string[] weekDayArray = weekDay.ToArray();
            for (int i = 0; i < weekDayArray.Length; i++)
            {
                Console.Write("{0}　", weekDayArray[i]);
            }
            Console.WriteLine();

            List<string> weekDayList = weekDayArray.ToList();
            foreach (string day in weekDayList)
            {
                Console.Write("{0}　", day);
            }

            Console.Read();
        }

      
    }
}
