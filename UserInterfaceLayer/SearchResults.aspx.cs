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
public partial class Search1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //HomeUserControl userControl = new HomeUserControl();
        //userControl.getDropDownList().SelectedIndex = Convert.ToInt32(Session["disease"].ToString());
        //access the values from session
        
        HomeUserControl userControl = new HomeUserControl();
       
         if (Session["disease"] != null &&(int)Session["choice"] == 1)
        {
            string str = Session["disease"].ToString();
            getQueryByDisease(str);
        }
        if(Session["Medicine"]!=null && (int)Session["choice"]==2)
        {
            string str = Session["Medicine"].ToString();
            getQueryByMedicine(str);
        }
        if (Session["Doctor"] != null && (int)Session["choice"] == 3)
        {
            string docId = Session["Doctor"].ToString();
            getQueryByDoctor(docId);
        }
        if (Session["Symptoms"] != null && (int)Session["choice"] == 4)
        {
            string symptoms = Session["Symptoms"].ToString();
            getQueryBySymptoms(symptoms);

        }
        

        //HomeUserControl1.DDLIndex =Convert.ToInt32(Session["disease"]);
        if (!Page.IsPostBack)
        {
            
        }

    }
    private void getQueryByDisease(string disease)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet ds = new DataSet();
        ds = businessLayerObj.getQuerry(disease, connectionString);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    public void getQueryByMedicine(string medicine)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet ds = new DataSet();
        ds = businessLayerObj.getQuerryByMedicine(medicine, connectionString);
        GridView1.DataSource = ds;
        GridView1.DataBind();

       
    }
    public void getQueryByDoctor(string doctorName)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsDoctor = new DataSet();
        dsDoctor = businessLayerObj.getQuerryByDoctor(doctorName, connectionString);
        GridView1.DataSource = dsDoctor;
        GridView1.DataBind();
    }
    public void getQueryBySymptoms(string symptoms)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsSymptoms = new DataSet();
        dsSymptoms = businessLayerObj.getQuerryBySymptoms(symptoms, connectionString);
        GridView1.DataSource = dsSymptoms;
        GridView1.DataBind();
    }

        

        
    
        



}
