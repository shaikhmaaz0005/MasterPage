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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(CS);
            conn.Open();

        }
                

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = TextBox1.Text;
            string pass = TextBox2.Text;
            string q = $"exec SignInn'{em}','{pass}'";
            SqlCommand cmd = new SqlCommand(q,conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    if ((rdr["email"].Equals(em) || rdr["username"].Equals(em)) && rdr["pass"].Equals(pass) && rdr["urole"].Equals("Admin"))
                    {
                        Session["MyUser"] = em;

                        Response.Redirect("AddProduct.aspx");
                    }

                    if (rdr["email"].Equals(em) && rdr["pass"].Equals(pass) && rdr["urole"].Equals("User"))
                    {
                        Session["MyUser"] = em;

                        Response.Redirect("FetchProduct.aspx");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid User Credentials);'</script>");
            }
            rdr.Close();
            conn.Close();
        }
    }
}