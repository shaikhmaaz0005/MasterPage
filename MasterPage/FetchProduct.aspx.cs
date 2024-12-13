using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage
{
    public partial class FetchProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchProduct();
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
    }
}