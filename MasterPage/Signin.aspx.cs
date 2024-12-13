using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = TextBox1.Text;
            string pass = TextBox2.Text;
            string q = $"exec SignU'{em}''{pass}'";
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    if (rdr["email"].Equals(em) && rdr["pass"].Equals(pass) && rdr["urole"].Equals("Admin"))
                    {
                        Response.Redirect("AdminHome.aspx");
                    }

                        if (rdr["email"].Equals(em) && rdr["pass"].Equals(pass) && rdr["urole"].Equals("User"))
                        {
                            Response.Redirect("AdminHome.aspx");
                        }
                    }
                }




                    else
                    {
                        Response.Write("<script>alert('Invalid User Credentials);'</script>");
                    }
                }
            }
        } 