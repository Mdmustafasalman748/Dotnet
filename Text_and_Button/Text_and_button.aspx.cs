using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Text_and_Button
{
    public partial class Text_and_button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
            protected void btn_Add_click(object sender, EventArgs e) {
            int firstNumber = Convert.ToInt32(txt_firstnumber.Text);
            int secondNumber = Convert.ToInt32(txt_secondnumber.Text);
            int Addition = firstNumber + secondNumber;
            Response.Write("Addition of two numbers is:" + Addition);
        }
        protected void btn_Sub_click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(txt_firstnumber.Text);
            int secondNumber = Convert.ToInt32(txt_secondnumber.Text);
            int Subtraction = firstNumber - secondNumber;
            Response.Write("Subtraction of two numbers is:" + Subtraction);
        }

    }
}
