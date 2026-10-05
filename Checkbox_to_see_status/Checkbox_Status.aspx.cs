using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checkbox_to_see_status
{
    public partial class Checkbox_Status : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkbox_1_checkedchanged(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Response.Write("un-checked");
            }
        }
        protected void checkbox_1_checkedchanged(string sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Response.Write("Checked");
            }
            else
            {
                Response.Write("Un-checked");
            }
        }
    }
}