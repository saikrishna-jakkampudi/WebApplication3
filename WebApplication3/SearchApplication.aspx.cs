using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class SearchApplication : System.Web.UI.Page
    {
        SqlConnection Con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            if (!IsPostBack)
            {
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
            SqlDataAdapter Adp = new SqlDataAdapter("select * from Census where Firstname=@fn or Lastname=@ln or Dob=@dob or ApplicationID=@appid", Con);
            if (TextBox1.Text != null)
                Adp.SelectCommand.Parameters.AddWithValue("@fn", TextBox1.Text);
            else
                Adp.SelectCommand.Parameters.AddWithValue("@fn", string.Empty);
            if (TextBox2.Text != null)
                Adp.SelectCommand.Parameters.AddWithValue("@ln", TextBox2.Text);
            else
                Adp.SelectCommand.Parameters.AddWithValue("@ln", string.Empty);
            if (TextBox3.Text != null)
                Adp.SelectCommand.Parameters.AddWithValue("@dob", TextBox3.Text);
            else
                Adp.SelectCommand.Parameters.AddWithValue("@dob", string.Empty);
            if (TextBox4.Text != null)
                Adp.SelectCommand.Parameters.AddWithValue("@appid", TextBox4.Text);
            else
                Adp.SelectCommand.Parameters.AddWithValue("@appid", string.Empty);

            DataSet ds = new DataSet();
        Adp.Fill(ds, "P");
            GridView1.DataSource = ds.Tables["P"];
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGridData();
        }
    }
}