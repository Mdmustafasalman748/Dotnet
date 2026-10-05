using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Webpage
{
    public partial class Webpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_click(object sender, EventArgs e)
        {
            string UserName=txt_UserName.Text;
            string Password=txt_Password.Text;
            if (UserName=="John" && Password=="John123")
            {
                Response.Redirect("Admin/Home.aspx");
            }
            else if(UserName=="Johnson" && Password == "Johnson123")
            {
                Response.Redirect("User/Home.aspx");
            }
            else
            {
                Response.Write("Please enter the correct credentials");
            }
        }
    }
}