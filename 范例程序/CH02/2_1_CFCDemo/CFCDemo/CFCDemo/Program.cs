using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFCDemo.Model;

namespace CFCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreModel model = new KTStoreModel();
            int c = model.Product.Count();
            Console.WriteLine(c);          
            Console.ReadLine();
        }
    }
}
