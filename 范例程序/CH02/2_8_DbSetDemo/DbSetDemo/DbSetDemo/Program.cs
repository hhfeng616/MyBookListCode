using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new KTStoreModel())
            {
                //////
                ////// ToString
                //////
                //string sql = context.Products.ToString();
                //Console.WriteLine(sql);


                //////
                ////// Find
                //////
                //Product product = context.Products.Find(
                //    7, "Visual C# 2010精要剖析");

                //if (product == null)
                //    Console.WriteLine("null");
                //else
                //    Console.WriteLine(product.Name);


                //////
                ////// SqlQuery
                //////
                //SqlParameter P0 = new SqlParameter("price", 80);

                //var query = context.Products.SqlQuery(
                //    "SELECT * FROM Product WHERE Price < @price ",
                //    P0) ;

                //foreach(var p in query)
                //{
                //    Console.WriteLine("{0}\t{1}\t订价：{2}", 
                //        p.Id,p.Name,p.Price);
                //}



                //////
                ////// Add 
                //////
                //Product p1 = new Product
                //{
                //    Id =24,
                //    Name ="Book1",
                //    Category ="Book",
                //    Price =55
                //};
                //Product p2 = new Product {
                //    Id = 25,
                //    Name = "Book2",
                //    Category = "Book",
                //    Price = 45
                //};

                //DbSet<Product> products = context.Products;
                //products.Add(p1);
                //products.Add(p2);
                //context.SaveChanges();

                //foreach (Product p in products)
                //{
                //    Console.WriteLine(p.Name);
                //}


                //////
                ////// AddRange
                //////  
                //Product p1 = new Product
                //{
                //    Id = 26,
                //    Name = "Book1XAAAA",
                //    Category = "Bookx",
                //    Price = 5506
                //};
                //Product p2 = new Product
                //{
                //    Id = 27,
                //    Name = "Book2XAAA",
                //    Category = "Bookx",
                //    Price = 457
                //};

                //List<Product> list = new List<Product>() { p1,p2 };
                //DbSet<Product> products = context.Products;
                //products.AddRange(list);
                // context.SaveChanges();

                //foreach (Product p in products)
                //{
                //    Console.WriteLine(p.Name);
                //}

                //////
                ////// Remove
                ////// 
                //Product product = context.Products.Find(27, "Book2XAAA");
                //if (product != null)
                //{
                //    context.Products.Remove(product);
                //    context.SaveChanges();
                //    Console.WriteLine("数据删除完成");
                //}
                //else
                //{
                //    Console.WriteLine("查无相关数据");
                //}


                //////
                ////// RemoveRange
                ////// 
                // IQueryable<Product> products= context.Products.Where(p => p.Id > 23);

                // context.Products.RemoveRange(products);
                // context.SaveChanges();
                // Console.WriteLine("数据删除完成");

            }
            Console.Read();

        }
    }
}
