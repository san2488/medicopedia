using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;

public partial class DatePicker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateMonths();
            PopulateYears();
        }
    }

    private void PopulateYears()
    {
        for (int year = DateTime.Now.Year; year > DateTime.Now.Year - 100; year--)
        {
            ddlYear.Items.Add(year.ToString());
        }
        ddlYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
    }

    private void PopulateMonths()
    {
        ddlMonth.Items.Add("January");
        ddlMonth.Items.Add("February");
        ddlMonth.Items.Add("March");
        ddlMonth.Items.Add("April");
        ddlMonth.Items.Add("May"); 
        ddlMonth.Items.Add("June");
        ddlMonth.Items.Add("July");
        ddlMonth.Items.Add("August");
        ddlMonth.Items.Add("September");
        ddlMonth.Items.Add("October");
        ddlMonth.Items.Add("November");
        ddlMonth.Items.Add("December");
        ddlMonth.Items.FindByValue(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)).Selected = true;
    }
    /// <summary>

    /// Replaces the standard post-back link for each calendar day 

    /// with the javascript to set the opener window's TextBox text.

    /// Eliminates a needless round-trip to the server.

    /// </summary>

    /// <param name="sender"></param>

    /// <param name="e"></param>


    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        // Clear the link from this day
        e.Cell.Controls.Clear();
        // Add the custom link
        System.Web.UI.HtmlControls.HtmlGenericControl Link = new System.Web.UI.HtmlControls.HtmlGenericControl();
        Link.TagName = "a";
        Link.InnerText = e.Day.DayNumberText;
        Link.Attributes.Add("onclick", string.Format("window.opener.document.getElementById('{0}').value = \'{1:d}\'; window.close()", Request.QueryString["field"], e.Day.Date));
        Link.Attributes.Add("href", "#");

        // By default, this will highlight today's date.
        if (e.Day.IsSelected)
        {
            Link.Attributes.Add("style", this.Calendar1.SelectedDayStyle.ToString());
        }
        // Now add our custom link to the page
        e.Cell.Controls.Add(Link);
    }

    protected void JumpToDate(object sender, EventArgs e)
    {
        Calendar1.TodaysDate = DateTime.Parse(ddlMonth.SelectedItem.Value + " 1, " + ddlYear.SelectedItem.Value);
    }
}
