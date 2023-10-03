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
        string selectSQL1;
        
        SqlDataReader reader;
        selectSQL = "insert into S1 (Rollno,Name)  values('" + TextBox2.Text + "','" + TextBox3.Text + "') ";
        selectSQL1 = "select * from S1 order by Rollno desc";
       
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlCommand cmd1 = new SqlCommand(selectSQL1, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            StringBuilder sb = new StringBuilder();
            reader = cmd1.ExecuteReader();
            reader.Read();
            sb.Append(reader["Rollno"]);
            sb.Append(reader["Name"]);
            Label1.Text = sb.ToString();

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
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
       
        string selectSQL2;

        string a = TextBox3.Text.ToString();
        selectSQL2 = "delete from S1 where Name ='"+a+"'";
        SqlCommand cmd2 = new SqlCommand(selectSQL2, con);

        try
        {
            con.Open();
            cmd2.ExecuteNonQuery();
            Label3.Text = "deleted";
 

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