using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string member = Request.QueryString["Member"];
            string appid = Request.QueryString["AppId"];

            Label1.Text = "Application is submitted with" + member + "Member Details";
            Label2.Text = "Your Application Id is" + appid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}