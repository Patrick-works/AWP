using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
        string selectSQL;

        selectSQL = "insert into S1 (Rollno,Name)  values('" + TextBox2.Text + "','" + TextBox3.Text + "') ";
       

        SqlCommand cmd = new SqlCommand(selectSQL, con);
        int add = 0;
        try
        {
            con.Open();
            add = cmd.ExecuteNonQuery();
            Label1.Text = add.ToString();

            
        }
        catch (Exception err)
        {
            Label1.Text = err.Message;
        }
        finally
        {
           
            con.Close();
        }


    }
}
