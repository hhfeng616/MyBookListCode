using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimStampDemo.Model;

namespace TimStampDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (KTStoreModel model = new KTStoreModel())
            {
                Product product = model.Products.Where(p => p.Id == 1).First();
                long ts = BitConverter.ToInt64(product.Timestamp, 0);
                Console.WriteLine("Quantity:{0}\tTimeStamp:{1}", product.Quantity, ts);

                try
                {
                    Console.Write("新的 Quantity 值：");
                    int quantity = int.Parse(Console.ReadLine());
                    product.Quantity = quantity;
                    model.SaveChanges();
                    ts = BitConverter.ToInt64(product.Timestamp, 0);
                    Console.WriteLine("Quantity:{0}\tTimeStamp:{1}", product.Quantity, ts);
                }
                catch (DbUpdateConcurrencyException ex)
                {

                    DbEntityEntry entry = ex.Entries.Single();
                    DbPropertyValues current = entry.CurrentValues;
                    int quantity = current.GetValue<int>("Quantity");
                    long timestamp = BitConverter.ToInt64(current.GetValue<byte[]>("Timestamp"), 0);

                    DbPropertyValues dbvalue = entry.GetDatabaseValues();
                    int dbquantity = dbvalue.GetValue<int>("Quantity");
                    long dbtimestamp = BitConverter.ToInt64(dbvalue.GetValue<byte[]>("Timestamp"), 0);

                    Console.WriteLine("DbUpdateConcurrencyException ... ");
                    Console.WriteLine("当前实体的属性值：Quantity:{0}\tTimeStamp:{1}", quantity, timestamp);
                    Console.WriteLine("数据库中的字段值：Quantity:{0}\tTimeStamp:{1}", dbquantity, dbtimestamp);
                    Console.WriteLine("\n");

                    ResolveConcurrency(model, entry);
                }
            }
            Console.ReadKey();
        }

        public static void ResolveConcurrency(KTStoreModel model, DbEntityEntry entry)
        {
            Console.Write("1. Database Wins　2. Client Wins ：");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                entry.Reload();
                model.SaveChanges();
                Console.WriteLine("与数据库同步完成－Database Wins");
            }
            else
            {
                entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                model.SaveChanges();
                Console.WriteLine("重新更新数据库完成－Client Wins");
            }
        }
    }
}