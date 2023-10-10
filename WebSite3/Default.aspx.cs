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
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

        if (e.Day.Date.Day == 5 && e.Day.Date.Month == 9)
        {
            Label lbl = new Label();
            lbl.Text = "Teacher day";
            e.Cell.Controls.Add(lbl);
            e.Cell.BackColor = System.Drawing.Color.Azure;
        }
        if (e.Day.Date.Day == 25 && e.Day.Date.Month == 12)
        {
            Calendar1.SelectedDate = new DateTime(2023, 12, 25);

            Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate,
                Calendar1.SelectedDate.AddDays(10));
            Label lb1 = new Label();
            lb1.Text = "Chrismax";
            e.Cell.Controls.Add(lb1);


        }

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "selected date is" + Calendar1.SelectedDate.Date;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

       TimeSpan cd = new DateTime(2023, 12, 31) - DateTime.Now;
        Label2.Text = cd.Days.ToString();
    }

}