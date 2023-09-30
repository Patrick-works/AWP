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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string selectSQL;
        string s = TextBox2.Text;
        int a = Convert.ToInt16(s);
        selectSQL = "SELECT * FROM CUSTTABLE ";
        selectSQL += "WHERE Age =" + a;
        // Define the ADO.NET objects.

      
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;
        
        ListBox1.Items.Clear();
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
           // reader.Read();
            // Build a string with the record information,
            // and display that in a label.
            while (reader.Read())
        {
            ListItem newItem = new ListItem();
            newItem.Text = reader["Name"].ToString();
            newItem.Value = reader["CustId"].ToString();
            ListBox1.Items.Add(newItem);
        }
            reader.Close();
        }
        catch (Exception err)
        {
            lblInfo.Text = "Error reading list of names. ";
            lblInfo.Text += err.Message;
        }
        finally
        {
            
            con.Close();
        }

    }
}



