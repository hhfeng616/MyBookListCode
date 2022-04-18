using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstOne.Model;
namespace CodeFirstOne
{
    class Program
    {
        static void Main(string[] args)
        {

            KTStoreModel model = new KTStoreModel();
            int c = model.Product.Count();
            Console.WriteLine(c);
        }
    }
}
