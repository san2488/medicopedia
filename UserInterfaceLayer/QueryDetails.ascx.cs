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
using DataClassLayer;

public partial class QueryDetails : System.Web.UI.UserControl
{
    SqlConnection connSql;
    SqlCommand cmdSql = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        PlaceHolder2.Visible = false;
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        connSql = new SqlConnection(connectionString);

        int queryId;

        queryId = Convert.ToInt32(Request.QueryString["QueryId"]);

        BusinessLayer businessLayerObj = new BusinessLayer();

        DataSet ds = businessLayerObj.GetQuery(queryId, connectionString);
        SqlDataSource dsrc = new SqlDataSource();
        //IDataSource ids = (IDataSource)ds;

        GridView1.DataSource = ds;
        GridView1.DataBind();

        
    }
    protected void btnSubmitAdvice_Click(object sender, EventArgs e)
    {
        Response.Redirect("SubmitAdvice.aspx");
    }
    protected void btnNeedsMoreInfo_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        int queryId;

        queryId = Convert.ToInt32(Request.QueryString["QueryId"]);

        BusinessLayer businessLayerObj = new BusinessLayer();

        businessLayerObj.UpdateQueryStatus(queryId, connectionString);

        PlaceHolder1.Visible = false;
        PlaceHolder2.Visible = true;

        
    }
    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueryHistory.aspx");
    }
}
