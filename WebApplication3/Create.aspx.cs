using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication3
{
    public partial class Create : System.Web.UI.Page
    {


        List<Population> list = new List<Population>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["P"] != null)
                list = (List<Population>)Session["P"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBclass D = new DBclass();
            int a = 0;
            
            Population P = new Population();

            P.ApplicationId = D.getAppid();

            P.MemberId = list.Count + 1;
            P.FirstName = TextBox1.Text;
            P.MiddleName = TextBox3.Text;
            P.LastName = TextBox4.Text;
            P.DateOfBirth = DateTime.Parse(TextBox2.Text);
            P.Suffix = DropDownList1.Text;
            P.Gender = RadioButtonList1.SelectedValue;
            list.Add(P);
            Session["P"] = list;
            Clear();
         
        }
        public void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            DropDownList1.SelectedIndex = -1;
            RadioButtonList1.SelectedIndex = -1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DBclass D = new DBclass();
            List<Population> L= D.SaveMembers(list); 
            Session.Remove("P");
            Response.Redirect("Confirmation.aspx?Member="+L.Count+"&AppId="+L[0].ApplicationId);

        }
    }
}