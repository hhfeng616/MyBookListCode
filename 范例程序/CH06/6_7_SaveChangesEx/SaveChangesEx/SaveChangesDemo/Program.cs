using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveChangesDemo.Model;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace SaveChangesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
                try
                {
                    Product product = new Product
                    {
                        //Name = "Entity Framework 精要",
                        //Price = 40,
                        //SPrice = -120


                        Name = null,
                        Price = -40,
                        SPrice = -120
                    };
                    context.Product.Add(product);
                    int count = context.SaveChanges();
                    Console.WriteLine("添加{0}项数据 !", count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n错误信息：{0}\n", ex.Message);

                    if (ex is DbEntityValidationException)
                    {

                        foreach (var validationResult in ((DbEntityValidationException)ex).EntityValidationErrors)
                        {
                            foreach (var error in validationResult.ValidationErrors)
                            {
                                Console.WriteLine(" … {0}", error.ErrorMessage);
                            }
                        }
                    }

                    // override SaveChanges()
                    // Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}