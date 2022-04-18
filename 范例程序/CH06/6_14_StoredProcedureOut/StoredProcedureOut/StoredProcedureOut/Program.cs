using StoredProcedureOut.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureOut
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KTStoreContext())
            {
                string sp = "SetSPriceById @P1,@P2, @P3,@P4 OUT";
                SqlParameter[] parameters = {
                    new SqlParameter("P1", 100),
                    new SqlParameter("P2", 10),
                    new SqlParameter("P3", 15),
                     new SqlParameter("P4", System.Data.SqlDbType.Int) {
                         Direction = System.Data.ParameterDirection.Output
                     }
                };
                context.Database.ExecuteSqlCommand(sp, parameters);
                Console.WriteLine("变更数据项数：{0}",parameters[3].Value.ToString());

                Console.ReadLine();
            }
        }
    }
}
