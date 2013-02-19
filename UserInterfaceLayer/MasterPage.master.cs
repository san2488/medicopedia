using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dsTips = new DataSet();
        dsTips.ReadXml(MapPath("staticdata/medicaltips.xml"));
        int tipsCount = dsTips.Tables[0].Rows.Count;
        Random rand = new Random();
        int randNum = rand.Next(tipsCount);

        lblMedTips.Text = dsTips.Tables["tip"].Rows[randNum]["text"].ToString();

        if (!IsPostBack)
        {
            DataSet dsInterest = new DataSet();
            dsInterest.ReadXml(MapPath("staticdata/diseases.xml"));
            ddlInterestList.DataSource = dsInterest;
            ddlInterestList.DataTextField = "name";
            ddlInterestList.DataValueField = "name";
            ddlInterestList.DataBind();
        }
        
        Session["disease"] = ddlInterestList.SelectedValue;

    }
    protected void logStatusMaster_LoggedOut(object sender, EventArgs e)
    {
        Session["Username"] = "default";
        Session["Role"] = "-1";
        Session["SignedIn"] = false;

    }
    protected void ddlInterestList_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["disease"] = ddlInterestList.SelectedValue;
    }
}
