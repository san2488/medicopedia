using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            HomeUserControl userControl = (HomeUserControl)Page.LoadControl("~/HomeUserControl.ascx");
            //PlaceHolder1.Controls.Add(userControl);
            //userControl.setTarget("~/Search1.aspx");
            //Session["disease"] = userControl.getDropDownList().SelectedIndex;
           
            
        }
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        
        
       
    }
}
