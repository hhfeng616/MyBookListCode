using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace AdonetDemo
{
    class OClass
    {

        public IEnumerable<Product> Products()
        {
            string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\KTStore.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            List<Product> products = new List<Product>();
            foreach (DataRow row in dataTable.Rows) {
                products.Add(this.TProduct(row));
            }
            return products;
        }

        public Product TProduct(DataRow row)
        {
            Product p = new Product()
            {
                Id = int.Parse(row["Id"].ToString()),
                Name = row["Name"].ToString(),
                Price = int.Parse(row["Price"].ToString()),
                SPrice = int.Parse(row["Price"].ToString()) * 0.6 ,
                Category = row["Category"].ToString()
            };
            return p ;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public double SPrice { get; set; }
    }
}
