using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string user = TextBox1.Text, pass = TextBox3.Text, email = TextBox2.Text, urole = "User";

            string query = $"exec FindExistingUser '{email}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if(rdr.HasRows)
            {
                Response.Write("<script>alert('user Already Exist!!!'); window.location.href='Signin.aspx';</script>");
            }
            else
            {
            string q = $"exec signupproc  '{user}','{email}','{pass}','{urole}'";
                new SqlCommand(q, conn).ExecuteNonQuery();
            Response.Write("<script>alert('User Registered Sucssefully!!!'); window.location.href='Signin.aspx';</script>");
                
            }
        }
    }
}
