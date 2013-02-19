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

public partial class UserHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Role"].ToString()!="0")
        {
            Response.Redirect("index.aspx");
        }
        PopulateData();
        lblAreaOfInterest.Text = Session["disease"].ToString();
        Session["AdviceId"] = null;
        Session["QueryId"] = null;
    }

    public void PopulateData()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        Query queryObj = new Query ();
        queryObj.QueryAreaOfInterest = Session["disease"].ToString(); ;
        DataSet dsTopTen = businessLayerObj.SelectTopTenAdvice(queryObj, connectionString);
        GridView1.DataSource = dsTopTen;
        GridView1.DataBind();
    }

    public String LimitWords(String Input)
    {
        // split input string into words (max 25...last words go in last element)
        String[] Words = Input.Split(new char[] { ' ' }, 25);

        // if we reach maximum words, replace last words with elipse
        if (Words.Length == 25)
            Words[24] = "...";
        else
            return Input;  // nothing to do

        // build new output string
        String Output = String.Join(" ", Words);
        return Output;
    }




    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        PopulateData();
    }
    protected void btnPostQuery_Click(object sender, EventArgs e)
    {
        Response.Redirect("SubmitQuery.aspx");
    }
    protected void btnShowHistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueryHistory.aspx");
    }
}
