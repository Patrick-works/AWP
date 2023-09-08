using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWP3A
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var n = TextBox1.Text;
            var m = RadioButtonList1.Text;
            if (n == "Aryan")
            {
                if (m == "BSCIT")
                {
                    Label1.Text = "Correct user, welcome bro";
                }
                else {
                    Label1.Text = "Incorrect user , wrong Aryan";
                }
            }
            else if (n == "Pratik")
            {
               if(m=="BMS"){
                    Label1.Text="Corret user , welcome deer";
               }
                else{
                    Label1.Text="Incorrect user , wrong pratik";
               }
            }
            else
            {
                Label1.Text = " Incoorect user ";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
