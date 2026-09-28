using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Technique
{
    public partial class Statemgmt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState.Add("Bill", 0);
                Session.Add("Name", "");
            }

        }
        protected void btn_submit_click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt32(txt_quantity.Text);
            int Price=Convert.ToInt32(txt_price.Text);
            int res = Quantity * Price;
            ViewState["Bill"] = res;
           // hdn_bill.Value=res.ToString();
        }
        protected void btn_percentage_click(object sender, EventArgs e)
        {
            int percentage = Convert.ToInt32(txt_percentage.Text);
            int res = Convert.ToInt32(ViewState["Bill"]);
            //int res=Convert.ToInt32(hdn_bill.Value);
            int bill = (res * percentage) / 100;
        }
        protected void btn_name_clcik(object sender, EventArgs e)
        {
            string Name = txt_name.Text;
            Session["Name"] = Name;
            Response.Redirect("Home.aspx");
            //For Query String
            //Response.Redirect("Home.aspx?name="+Name);
            //Response.Redirect("https://www.google.com");
            //Server.Transfer("Home.apsx");
            //Server.Transfer("https://www.google.com/");
        }
        //Aspx.cs for Query string
       * public partial class Home:System.Web.UI.Page
         * {
         * protected void Page_Load(object sender, EventArgs e)
         * {
         *string WelcomeName=Session["Name"].ToString();
         *string WelcomeName=Request.QueryString["Name"].ToString();
         *Response.Write("Welcome"+WelcomeName+"To Home Page");
         *}
         *}
         
    }
}