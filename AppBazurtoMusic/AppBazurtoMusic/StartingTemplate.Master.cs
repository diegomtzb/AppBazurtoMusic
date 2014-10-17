using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppBazurtoMusic
{
    public partial class MyBootstrap : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void add_cart()
        {
            string name = cart_number.InnerHtml.ToString();
            
            if (name != ""){
                int num = Int32.Parse(name);
                num = num + 1;
                cart_number.InnerHtml = num.ToString();
            } else {
                cart_number.InnerHtml = "1";
            }

        }
    }
}