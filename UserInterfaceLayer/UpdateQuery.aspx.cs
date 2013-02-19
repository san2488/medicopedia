using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessClassLayer;
using DomainClassLayer;

public partial class UpdateQuery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PlaceHolder1.Visible = true;
        PlaceHolder2.Visible = false;
        if (Session["Role"].ToString() != "0")
        {
            Response.Redirect("index.aspx");
        }
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        SqlConnection connSql = new SqlConnection(connectionString);


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string connString = ConfigurationManager.AppSettings.Get("connString");

        Query queryObj = new Query();

        queryObj.QueryId = int.Parse(Request.QueryString["QueryId"]);
        queryObj.Username = Request.QueryString["Username"];
        queryObj.QueryAreaOfInterest = UserControl1.SelectedValue; ;
        queryObj.Symptoms = txtSymptoms.Text; ;
        queryObj.MedicalHistory = txtMedicalHistory.Text;
        queryObj.Status = "Unanswered";
        queryObj.IsAttendedTo = true;
        queryObj.PostedDatetime = DateTime.Now;


        BusinessLayer businessLayerObj = new BusinessLayer();

        businessLayerObj.UpdateQuery(queryObj, connString);
        PlaceHolder1.Visible = false;
        PlaceHolder2.Visible = true;


    }
    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueryHistory.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueryHistory.aspx");
    }
}
