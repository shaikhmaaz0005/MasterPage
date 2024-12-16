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
    public partial class Site2 : System.Web.UI.MasterPage
    {

        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();

            if (Session["MyUser"] != null)
            {
                string em = Session["MyUser"].ToString();
                string q = $"exec FindUserByEmail'{em}'";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                Label1.Text = rdr["username"].ToString();

            }
            else
            {
                Response.Write("<script>alert('You need Login');window.location.href='Signin.aspx</script>");
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)


        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Signin.aspx");
        }
    }
}