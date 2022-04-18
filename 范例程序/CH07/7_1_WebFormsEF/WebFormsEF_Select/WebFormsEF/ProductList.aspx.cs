using System;
using System.Linq;
using WebFormsEF.Models;

namespace WebFormsEF
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /* public IQueryable<Product> SelectProduct()
        {
            KTStoreEntities entities = new KTStoreEntities();
            var products = entities.Product;
            return products;
        }*/

        public IQueryable<Product> SelectProduct(
            [System.Web.ModelBinding.Control("ProductName")] string name)
        {
            KTStoreEntities entities = new KTStoreEntities();
            var products = entities.Product.Where(P=>P.Name.Contains(name)) ;
            return products;
        }
        public void UpdateProduct(int id) {

            KTStoreEntities entities = new KTStoreEntities();
            Product product = entities.Product.Find(id);
            TryUpdateModel(product);
            if (ModelState.IsValid)
            {
                entities.SaveChanges();
            }
        }
        public void DeleteProduct(int id) {
            KTStoreEntities entities = new KTStoreEntities();
            Product product = entities.Product.Find(id);
            entities.Product.Remove(product);
            entities.SaveChanges();            
        }

        protected void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/ProductDetail?id=" + Products.SelectedRow.Cells[1].Text);
        }

    }
}