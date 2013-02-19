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
using System.Web.SessionState;
public partial class HomeUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

       
        if (!Page.IsPostBack)
        {
            PopulateDdlDiseases();
            PopulateDdlMedicines();
            PopulateDoctors();
        }
        
    }

    protected void PopulateDdlDiseases()
    {
        DataSet dsdiseases = new DataSet();
        DataTable tblDiseases = new DataTable("disease");
        tblDiseases.Columns.Add("name", typeof(string));

        dsdiseases.Tables.Add(tblDiseases);
        dsdiseases.ReadXml(MapPath(@"staticdata/diseases.xml"), XmlReadMode.Auto);
        ddlDiseases.DataSource = dsdiseases;
        ddlDiseases.DataTextField = dsdiseases.Tables["disease"].Columns["name"].ToString();
        ddlDiseases.DataValueField = dsdiseases.Tables["disease"].Columns["name"].ToString();
        //DDLIndex = ddlDiseases.SelectedIndex;
        ddlDiseases.DataBind();
        ListItem item = new ListItem();
        item.Text = "Select";
        item.Value = "0";
        ddlDiseases.Items.Insert(0, item);
        if (Request.Cookies["disease"] != null)
        {
           ddlDiseases.SelectedIndex = Convert.ToInt32(Request.Cookies["disease"].Value.ToString() );
        }
        //ddlDiseases.SelectedIndex = Convert.ToInt32(Session["selected"].ToString());
        
     }

    protected void PopulateDdlMedicines()
    {
        DataSet dsmedicine = new DataSet();
        DataTable tblmedicine = new DataTable("medicine");
        tblmedicine.Columns.Add("name", typeof(string));

        dsmedicine.Tables.Add(tblmedicine);
        dsmedicine.ReadXml(MapPath(@"staticdata/medicines.xml"),XmlReadMode.Auto);
        ddlMedicines.DataSource = dsmedicine;
        ddlMedicines.DataTextField = dsmedicine.Tables["medicine"].Columns["name"].ToString();
        ddlMedicines.DataValueField = dsmedicine.Tables["medicine"].Columns["name"].ToString();

        ddlMedicines.DataBind();
        ListItem item = new ListItem();
        item.Text = "Select";
        item.Value = "0";
        ddlMedicines.Items.Insert(0, item);
        if (Request.Cookies["medicine"] != null)
        {
            ddlMedicines.SelectedIndex = Convert.ToInt32(Request.Cookies["medicine"].Value.ToString());
        }
    }
    public void PopulateDoctors()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsDoctor = new DataSet();
        dsDoctor = businessLayerObj.getDoctor(connectionString);
        ddlDoctors.DataSource = dsDoctor;
        ddlDoctors.DataTextField = dsDoctor.Tables[0].Columns[1].ToString();
        ddlDoctors.DataValueField = dsDoctor.Tables[0].Columns[1].ToString();
        ddlDoctors.DataBind();
        ListItem item = new ListItem();
        item.Text = "Select";
        item.Value = "0";
        ddlDoctors.Items.Insert(0, item);
        if (Request.Cookies["doctor"] != null)
        {
            ddlDoctors.SelectedIndex = Convert.ToInt32(Request.Cookies["doctor"].Value.ToString());
        }
        
        
        
    }


        
   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Disese = ddlDiseases.SelectedItem.Text.ToString();
        Session["disease"] = disese;
        Session["choice"] = 1;
        //Session["selected"] = ddlDiseases.SelectedIndex.ToString();
       
        Response.Cookies["disease"].Value = ddlDiseases.SelectedIndex.ToString();
        Response.Cookies["medicine"].Value = "0";
        Response.Cookies["doctor"].Value = "0";
        
            Response.Redirect("SearchResults.aspx");
        
    }
    public DropDownList getDropDownList()
    {
        return ddlDiseases;
    }
    string disese;
    public string Disese
    {
        get { return disese; }
        set { disese = value; }
    }
    public void setIndex(string name)
    {
        //DropDownList1 = name;
    }
    public int DDLIndex
    {
        get {return  ddlDiseases.SelectedIndex; }
        set { ddlDiseases.SelectedIndex = value; }
    }
    string medicine;
    public string Medicine
    {
        get { return ddlMedicines.SelectedValue; }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Medicine"] = ddlMedicines.SelectedValue.ToString();
       
        Session["choice"] = 2;
        Response.Cookies["medicine"].Value = ddlMedicines.SelectedIndex.ToString();
        Response.Cookies["disease"].Value = "0";
        Response.Cookies["doctor"].Value = "0";
        Response.Redirect("SearchResults.aspx");
    
        

    }
    protected void ddlDoctors_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Doctor"] = ddlDoctors.SelectedValue;

        Session["choice"] = 3;
        Response.Cookies["doctor"].Value = ddlDoctors.SelectedIndex.ToString();
        Response.Cookies["medicine"].Value = "0";
        Response.Cookies["disease"].Value = "0";
        Response.Redirect("SearchResults.aspx");
    }
    protected void btnSymptoms_Click(object sender, EventArgs e)
    {
        string symptoms = txtSymptoms.Text;
        Session["Symptoms"] = symptoms;
        Session["choice"] = 4;
        Response.Redirect("SearchResults.aspx");

    }
}
