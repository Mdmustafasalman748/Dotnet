using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checkbox
{
    public partial class Checkbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chk_male_checkedchanged(object sender, EventArgs e)
        {
            if (chk_Male.Checked)
            {
                chk_Female.Checked = false;
            }
            else
            {
                chk_Male.Checked = true;
            }

        }

        protected void chk_female_checkedchanged(object sender, EventArgs e)
        {
            if (chk_Female.Checked)
            {
                chk_Male.Checked = false;
            }
            else
            {
                chk_Female.Checked = true;
            }
        }
    }
}