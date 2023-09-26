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
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string selectSQL;

        selectSQL = "SELECT * FROM Student_Master ";
        selectSQL += "WHERE control_id ='" + ListBox1.SelectedItem.Value + "'";
        // Define the ADO.NET objects.

        Label1.Text = selectSQL;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;
        // Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            // Build a string with the record information,
            // and display that in a label.
            StringBuilder sb = new StringBuilder();
            sb.Append("<b>");
            sb.Append(reader["control_id"]);
            sb.Append(", ");
            sb.Append(reader["name"]);
            sb.Append("</b><br />");
            sb.Append("Phone: ");
            sb.Append(reader["contactno"]);
            sb.Append("<br />");
            sb.Append("Address: ");
            sb.Append(reader["address"]);
            sb.Append("<br />");
            sb.Append("EmailId: ");
            sb.Append(reader["email_id"]);
            sb.Append("<br />");
            Label1.Text += sb.ToString();
            reader.Close();
        }
        catch (Exception err)
        {
            Label1.Text = "Error getting author. ";
            Label1.Text += err.Message;
        }
        finally
        {
            Label1.Text += "DONE";
            con.Close();
        }

    }
}
