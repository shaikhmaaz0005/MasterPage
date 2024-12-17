using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace MasterPage
{
    public partial class FetchProduct : System.Web.UI.Page
    {

        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(CS);
            conn.Open();


            {
                if (!IsPostBack)
                {
                    FetchProduct();
                }
                else
                {

                }

            }


            public void FetchProduct()


            {
                string q = "exec FetchProd";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataSet1.DataSource = ds; //loctae your data
                DataSet1.DataBind(); // to display the data

                string q = "exec FetchProd";
                SqlConnection cmd = new SqlConnection(q, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataList1.Datasource = reader;
                DataList1.Databind();

            }

            protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
            {
                if (e.CommandName == "AddToCart")
                {
                    string q2 = $"exec findProductById '{e.CommandArgument.ToString()}'";
                    SqlCommand cmd = new SqlCommand(q2, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();
                    string prod_name = r["pname"].ToString();
                    string prod_cat = r["pcat"].ToString();
                    string prod_pic = r["pic"].ToString();
                    double prod_price = double.Parse(r["price"].ToString());

                    string pdate = DateTime.Now.ToString("dd/MM/yyyy");
                    DropDownList dropdown = e.Item.FindControl("DropdownList1") as DropDownList;
                    int quantity = int.Parse(dropdown.SelectedValue.ToString());

                    double total = prod_price * quantity;
                    string suser = Session["MyUser"].ToString();

                    string q3 = $"exec AddToCart '{prod_name}','{prod_cat}','{prod_pic}','{prod_price}','{quantity}','{total}','{pdate}','{suser}'";
                    SqlCommand cmd = new SqlCommand(q3, conn);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Cart.aspx");
                }
            }
        }

    }
}
