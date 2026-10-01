using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connected_architecture
{
    public partial class Connected_architecture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bindgrid();

        }
        public void Bindgrid()
        {
            String s = "Data Source=DESKTOP-TQG5160:InitialCatalog=batch;Integrated Security=True";
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd= new SqlCommand("select * from tbl_dept",con);
            SqlDataReader dr=cmd.ExecuteReader();
            grid_deptdetails.DataSource = dr;
            grid_deptdetails.DataBind();
            con.Close();
        }

    }
}