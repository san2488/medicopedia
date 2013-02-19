using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using BusinessClassLayer;
using System.Data;

public partial class AdviceDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetAdvices();
        //if (bool.Parse(Session["SignedIn"].ToString()) == false)
        //{
        //    Response.Redirect("Login.aspx");
        //}
        //else if (Session["Role"].ToString() != "1")
        //{
        //    btnAddAdvice.Visible = false;
        //}

        Session["AdviceId"]= null;
        Session["QueryId"] = null;
        if (Session["Role"].ToString()!="1")
        {
            btnAddAdvice.Visible = false;
        }
    }

    private void GetAdvices()
    {
        int id =Convert.ToInt32(Request.QueryString["QueryId"].ToString());
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet ds = new DataSet();
        ds = businessLayerObj.getAdvice(id, connectionString);
        
        
        GridView1.DataSource = ds;
        GridView1.DataBind();


       
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SubmitAdvice.aspx?QueryId=" + Request.QueryString["QueryId"].ToString());
    }
    
}