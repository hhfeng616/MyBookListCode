using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsR.Model;

namespace WebFormsR
{
    public partial class CategoryProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                   
        }

        public IQueryable<Category> FillCategory()
        {
            KTStoreEntities entities = new KTStoreEntities();
            var categories = entities.Category;
            return categories;
        }

        protected void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id =int.Parse( CategoryList.SelectedValue) ;
            //CategoryId.Value = id.ToString();
       
            KTStoreEntities entities = new KTStoreEntities();    

            var products = entities.Category.Where(c => c.Id == id).Single().Product;
            Products.DataSource = products.ToList();
            Products.DataBind();
        }   

    }
}