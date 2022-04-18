using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectDemo
{
    class SelectShap
    {
        public static void shap()
        {
            using (var context = new KTStoreModel())
            {

                ////
                ////
                //var products =
                //    from product in context.Products
                //    select new {
                //        product.Name,product.Price };
                //foreach (var product in products)
                //{
                //    Console.WriteLine("价格：{0}\t{1}",
                //          product.Price, product.Name);
                //}

                ////
                ////
                //var products =
                //    from product in context.Products
                //    select new
                //    {
                //        ProductName = product.Name,
                //        Price = product.Price,
                //        SPrice = product.Price * 0.8
                //    };
                //foreach (var product in products)
                //{
                //    Console.WriteLine("价格：{0}\t特价：{1}\t商品：{2}",
                //          product.Price, product.SPrice, product.ProductName);
                //}

                ////
                ////
                //IEnumerable<SProduct> products =
                //    from product in context.Products
                //    select new SProduct()
                //    {
                //        PId = product.Id.ToString().PadLeft(4, '0'),
                //        CName = product.Category + "_" + product.Name,
                //        Price = product.Price,
                //        SPrice = product.Price * 0.8
                //    };


                //
                //
                IEnumerable<SProduct> products =
                                   from product in context.Products.ToList()
                                   select ToSProduct(product);

                foreach (var product in products)
                {
                    Console.WriteLine("{0}\t订价：{1}\t特价：{2}\t{3}",
                          product.PId, product.Price, product.SPrice, product.CName);
                }
            }
        }

        static SProduct ToSProduct(Product product)
        {
            return new SProduct()
            {
                PId = product.Id.ToString().PadLeft(4, '0'),
                CName = product.Category + "_" + product.Name,
                Price = product.Price,
                SPrice = product.Price * 0.8
            };

        }


    }
    class SProduct
    {
        public string PId { get; set; }
        public string CName { get; set; }
        public int Price { get; set; }
        public double SPrice { get; set; }
    }
}

