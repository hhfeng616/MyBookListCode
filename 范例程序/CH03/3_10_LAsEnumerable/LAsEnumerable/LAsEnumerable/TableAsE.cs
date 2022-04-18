using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LAsEnumerable
{
    class TableAsE
    {
        public static void TableAsEnumerable()
        {

            string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\KTStore.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            // EnumerableRowCollection<DataRow> products =
            //    from product in dataTable.AsEnumerable()
            //    select product;

            //foreach (var p in products) { 

            //    Console.WriteLine("{0}\t{1}",
            //        p.Field<string>("Name") ,
            //        p.Field<int>("Price")  );
            //}

            EnumerableRowCollection<Product> products =
            from product in dataTable.AsEnumerable()
            select new Product() {
                Id= product.Field<int>("Id"),
                Name = product.Field<string>("Name"),
                Price = product.Field<int>("Price"),
                Category = product.Field<string>("Category"),
            };  

            foreach (var p in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    p.Id,
                    p.Name,
                    p.Price,
                    p.Category);
            }
            Console.WriteLine(dataTable.Rows.Count);
        }
    }
}
