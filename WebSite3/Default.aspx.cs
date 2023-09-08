using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = ListBox1.SelectedItem.ToString();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
         
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Text = ListBox1.SelectedItem.Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Remove(ListBox1.SelectedItem);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = ListBox1.Items.Count.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(TextBox1.Text);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        foreach (ListItem l in ListBox1.Items)
            if (l.Selected)
                    Label1.Text += l.Text.ToString();
    }
    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void BulletedList1_Click1(object sender, BulletedListEventArgs e)
    {

    }
}
