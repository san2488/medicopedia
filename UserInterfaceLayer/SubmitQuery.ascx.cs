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
using DomainClassLayer;
using BusinessClassLayer;

public partial class SubmitQuery : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PlaceHolder2.Visible = false;
        if (!IsPostBack)
        {
            DataSet dsInterest = new DataSet();
            dsInterest.ReadXml(MapPath("staticdata/diseases.xml"));
            ddlInterestList.DataSource = dsInterest;
            ddlInterestList.DataTextField = "name";
            ddlInterestList.DataValueField = "name";
            ddlInterestList.DataBind();
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            

        
    }

    public string SaveQuery()
    {
        
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        ListItem li = new ListItem();
        string symptoms = string.Empty ;
        
        Query queryObj = new Query();
        int i = 0; int counter = 0;

        int max = counter;
        counter = 0;

        

        queryObj.Username = Session["Username"].ToString();
        queryObj.QueryAreaOfInterest = ddlInterestList.SelectedItem.Value;
        queryObj.Symptoms = txtSymptoms.Text;
        queryObj.MedicalHistory = txtMedHistory.Text;
        queryObj.Status = "Unanswered";
        queryObj.IsAttendedTo = false;
        queryObj.PostedDatetime = DateTime.Now;

        //passing to business layer 

        //string message;     
        BusinessLayer businessLayerObj = new BusinessLayer();
        try
        {
            businessLayerObj.InsertQuery(queryObj, connectionString);
        }
        catch(Exception ex)
        {
            return ex.Message;
        }

        return "noerror";
    }

        // lblErrorMessage.Text = ex.Message;


   

    protected void ddlDisease_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        //PlaceHolder1.Visible = false;
        //PlaceHolder2.Visible = false;
        string message = SaveQuery();

        if (message.Equals("noerror"))
        {
            PlaceHolder1.Visible = false;
            PlaceHolder2.Visible = true;
            return;
        }

        else
        {
            lblErrorMessage.Text = message;
        }
    }
}
