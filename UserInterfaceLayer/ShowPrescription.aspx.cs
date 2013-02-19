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

public partial class Prescriptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int queryId =Convert.ToInt32(Request.QueryString["QueryId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        string connection = ConfigurationManager.AppSettings.Get("connString");
        DataSet ds =  businessLayerObj.getPrescription(queryId, connection);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void btnAddPrescription_Click(object sender, EventArgs e)
    {
        Response.Redirect("Prescribe.aspx?QueryId=" + Request.QueryString["QueryId"]);
    }
}
