using System;

namespace WebFormsApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGreet_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Hello, " + Server.HtmlEncode(txtName.Text) + "!";
        }
    }
}
