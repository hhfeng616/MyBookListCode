using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foxdog = {
                @"the quick brown fox 
                jumps over the lazy dog"};

            IEnumerable<char> enumfoxdog = 
                from words in foxdog
                from fd in words
                where fd != ' '
                orderby fd
                select fd;

            foreach (char d in enumfoxdog)
            {
                Console.Write("{0},", d);
            }

            IEnumerable<char> sEnumfoxdog = enumfoxdog.Distinct();         
            foreach (char d in sEnumfoxdog)
            {
                Console.Write("{0},",d);
            }            
            Console.ReadKey();

        }
    }
}
