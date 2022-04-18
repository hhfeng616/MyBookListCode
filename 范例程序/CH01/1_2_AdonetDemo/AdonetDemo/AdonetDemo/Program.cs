using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace AdonetDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            IEnumerable<Product> products = (new OClass()).Products();
            foreach(Product p in products)
            {
                int id = p.Id ;
                string name = p.Name ;
                int price = p.Price ;
                string category = p.Category ;
                double sprice = p.SPrice ;
                Console.WriteLine("{3}\t订价：{2}\t特价：{4}\t{0}\t{1}",
                    id, name, price, category,sprice);
            }

            //string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\KTStore.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework";
            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);
            //conn.Open();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //da.Fill(dataTable);
            //conn.Close();
            //da.Dispose();

            //Console.WriteLine("商品数据项数：{0}\n", dataTable.Rows.Count);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    int id = int.Parse(row["Id"].ToString());
            //    string name = row["Name"].ToString();
            //    int price = int.Parse(row["Price"].ToString());
            //    string category = row["Category"].ToString();
            //    Console.WriteLine("{3}\t订价：{2}\t{0}\t{1}", 
            //        id, name,price,category);
            //}
            Console.Read();
        }
    }
}