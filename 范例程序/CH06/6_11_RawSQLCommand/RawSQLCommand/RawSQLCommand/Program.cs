using System;
using RawSQLCommand.Model;
namespace RawSQLCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
               // string sql = "UPDATE Product SET SPrice = -1 WHERE Price > 100";
               // int count = context.Database.ExecuteSqlCommand(sql);


                object[] parameters = {0,100 };
                string sql = "UPDATE Product SET SPrice = @P0 WHERE Price > @P1";
                int count = context.Database.ExecuteSqlCommand(sql, parameters);
                Console.WriteLine("更新数据项数：{0}",count);

                Console.ReadLine();
            }
        }
    }
}
