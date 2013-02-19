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

public partial class DiseaseList : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dsInterest = new DataSet();
        dsInterest.ReadXml(MapPath("staticdata/diseases.xml"));
        ddlInterestList.DataSource = dsInterest;
        ddlInterestList.DataTextField = "name";
        ddlInterestList.DataValueField = "name";
        ddlInterestList.DataBind();
    }

    private string selectedValue;

    public string SelectedValue
    {
        get { return selectedValue; }
        set { selectedValue = value; }
    }
    protected void ddlInterestList_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedValue = ddlInterestList.SelectedValue;
    }
    public DropDownList GetDropDownList()
    {
        return ddlInterestList;
    }
}
