using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbChangeTrackerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreModel())
            {

                var products = context.Product.Where(p => p.Id < 4).ToList();
                DbChangeTracker tracker = context.ChangeTracker;
                EntryInfo(tracker, "首次载入");

                Product firstProduct = products.First();
                firstProduct.Name = "ASP.NET MVC 上手实践";
                firstProduct.Price = 19;
                EntryInfo(tracker, "变更第一项商品数据的名称");

                context.Product.Add(
                    new Product
                    {
                        Name = "BOOK A001",
                        Price = 199,
                        SPrice = 99
                    });
                //  context.SaveChanges();      
                EntryInfo(tracker, "添加一项商品数据");

                Product dp = products.Last();
                context.Product.Remove(dp);
                EntryInfo(tracker, "删除一项商品数据");

                Console.Read();
            }
        }
        static void EntryInfo(DbChangeTracker tracker, string desc)
        {
            Console.WriteLine("\n{0}：", desc);
            Console.WriteLine("".PadRight(48, '.'));
            IEnumerable<DbEntityEntry> entries = tracker.Entries();

            foreach (DbEntityEntry entry in entries)
            {
                Console.WriteLine("变更实体： {0}", entry.Entity.GetType().FullName);
                EntityState state = entry.State;

                Console.WriteLine("状态： {0}", state);
                if (state != EntityState.Deleted)
                {
                    if (state != EntityState.Added)
                    {
                        PropertyList(entry.GetDatabaseValues(), "当前数据库中的复本");
                        PropertyList(entry.OriginalValues, "属性值");
                    }
                    if (state != EntityState.Unchanged)
                    {
                        PropertyList(entry.CurrentValues, "变更后的属性值");

                    }
                }
                Console.WriteLine("//");
            }
        }
        static void PropertyList(DbPropertyValues values, string desc)
        {
            Console.WriteLine("{0}： ", desc);
            foreach (string pname in values.PropertyNames)
            {
                Console.WriteLine("\t{0}:{1}", pname, values[pname]);
            }
        }

    }
}