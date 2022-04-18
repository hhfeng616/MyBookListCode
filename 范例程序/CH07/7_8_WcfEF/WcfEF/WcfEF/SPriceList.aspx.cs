using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfEF
{
    public partial class SPriceList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void IdButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {

                ServiceReference1.ProductSPrice product = client.ProductSpriceList(id);
                if (product != null)
                {
                    int pid = product.ID;
                    string pname = product.IdName;
                    string pprice = product.SPrice;
                    LabelName.Text = "编号：" + pid + "　" + pname + "　价格:" + pprice;
                }
                else
                {
                    LabelName.Text = "无商品";
                }
                ProductGridView.DataSource = null; ProductGridView.DataBind();
            }
        }

        protected void ProductButton_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                ServiceReference1.ProductSPrice[] products = client.ProductSpriceAll();
                ProductGridView.DataSource = products;
                ProductGridView.DataBind();
                LabelName.Text = "";
                IdTextBox.Text = "";
            }
        }
    }
}