using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsEF.Models;

namespace WebFormsEF
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public object Product_GetItem()
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                KTStoreEntities entities = new KTStoreEntities();
                var product = entities.Product.Where(p => p.Id == id);
                return product;
            }
            else { return null; }
        }
    }
}