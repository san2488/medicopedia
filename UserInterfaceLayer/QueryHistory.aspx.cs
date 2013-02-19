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
using BusinessClassLayer;
using DataClassLayer;
using DomainClassLayer;

public partial class QueryHistory : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Role"].ToString() != "0")
        {
            Response.Redirect("index.aspx");
        }
        FillGrid1();
        FillGrid2();
    }
    public void FillGrid1()
    {
        DataSet dsQuerydetails = new DataSet();
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Query queryObj = new Query();
        //queryObj.Username = Session["Username"].ToString();
        queryObj.Username = Session["Username"].ToString();
        BusinessLayer businessObj = new BusinessLayer();
        //dsQuerydetails = businessObj.GetQueryDetailsByUsername(queryObj, connectionString);
        dsQuerydetails = businessObj.GetQueryWithFurtherUserDetails(queryObj, connectionString);
        gvShowQuery.DataSource = dsQuerydetails;
        gvShowQuery.DataBind();
    }


    public void FillGrid2()
    {
        DataSet dsQuerydetails = new DataSet();
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Query queryObj = new Query();
        //queryObj.Username = Session["Username"].ToString();
        queryObj.Username = Session["Username"].ToString();
        BusinessLayer businessObj = new BusinessLayer();
        //dsQuerydetails = businessObj.GetQueryWithFurtherUserDetails(queryObj,connectionString);
        dsQuerydetails = businessObj.GetQueryDetailsByUsername(queryObj, connectionString);
        GridView1.DataSource = dsQuerydetails;
        GridView1.DataBind();
    }
    protected void gvShowQuery_PageIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void gvShowQuery_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvShowQuery.PageIndex = e.NewPageIndex;
        FillGrid1();
    }

    protected void gvShowQuery_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        FillGrid2();
    }
}
