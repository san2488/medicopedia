using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessClassLayer;
using System.Configuration;
using DomainClassLayer;
public partial class DoctorHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Role"].ToString() != "1")
        {
            Response.Redirect("index.aspx");
        }

        //Session["UserName"] = "Sujay"; 
        GetWorklist();
   
    }

    private void GetWorklist()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        DataSet wrkListNotAttended = new DataSet();
        DataSet wrkListAttended =new DataSet();
        Doctor doctor = new Doctor();
        doctor.Username = Session["UserName"].ToString(); ;
     

        BusinessLayer businessLayerObj = new BusinessLayer();

       
       
        wrkListNotAttended = businessLayerObj.getWorkList(false,doctor, connectionString);
        wrkListAttended = businessLayerObj.getWorkList(true, doctor,connectionString);
        GridView1.DataSource = wrkListNotAttended;
        GridView2.DataSource = wrkListAttended;
        GridView1.DataBind();
        GridView2.DataBind();
        
    }
    protected void GridViewWorkList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
