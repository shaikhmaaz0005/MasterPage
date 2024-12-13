using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage
{
    public partial class AddProduct : System.Web.UI.Page
    {
        SqlConnection conn;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(CS);
            conn.Open();

            if (Session["Username"] != null)
            {
                Label1.Text = $"Hello {Session["Username"]}";
            }
            else
            {
                Response.Write("<script>alert('Need to login');window.location.href='Login.aspx';</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string prod_name = TextBox1.Text, prod_cat = DropDownList1.SelectedValue, prod_img;
            double prod_price = double.Parse(TextBox2.Text);

            FileUpload1.SaveAs(Server.MapPath("Images/") + Path.GetFileName(FileUpload1.FileName));
            prod_img = "Images/" + Path.GetFileName(FileUpload1.FileName);

            string q = $"exec Insertproduct '{prod_name}','{prod_cat}','{prod_price}','{prod_img}'";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Emp Added Successfully')</script>");
        }
    }
}