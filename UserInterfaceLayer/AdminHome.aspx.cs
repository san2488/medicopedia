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
using DomainClassLayer;
using DataClassLayer;
using System.Data.SqlClient;
using System.Xml;

public partial class DoctorApproval : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        string connectString = ConfigurationManager.AppSettings.Get("connString");
        SqlConnection objConn = new SqlConnection(connectString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_SelectUnapprovedDoctor";
        cmd.Connection = objConn;
        objConn.Open();

        SqlDataAdapter daDoctors = new SqlDataAdapter(cmd);
        DataSet dsDoctors = new DataSet("Doctor");
        daDoctors.FillSchema(dsDoctors, SchemaType.Source, "Doctor");
        daDoctors.Fill(dsDoctors, "Doctor");
        AdminDoctorView.DataSource = dsDoctors;
        AdminDoctorView.DataBind();

        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandType = CommandType.StoredProcedure;
        cmd2.CommandText = "usp_SelectAllUsers";
        cmd2.Connection = objConn;
        objConn.Close();
        objConn.Open();

        SqlDataAdapter daUsers = new SqlDataAdapter(cmd2);
        DataSet dsUsers = new DataSet("Users");
        daUsers.FillSchema(dsUsers, SchemaType.Source, "Users");
        daUsers.Fill(dsUsers, "Users");
        AdminUserView.DataSource = dsUsers;
        AdminUserView.DataBind();
    }
    protected void addMedicine()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(@"D:\Anand\Wednesday\Medicopedia\Medicopedia\UserInterfaceLayer\staticdata\medicines.xml");
        XmlElement e1 = doc.CreateElement("medicine");
        XmlElement e2 = doc.CreateElement("name");
        e2.InnerText = txtName.Text;
        e1.AppendChild(e2);
        doc.DocumentElement.AppendChild(e1);
        doc.Save(@"staticdata\medicines.xml");
    }
    protected void addDisease()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(@"staticdata\diseases.xml");
        XmlElement e1 = doc.CreateElement("disease");
        XmlElement e2 = doc.CreateElement("name");
        e2.InnerText = txtName.Text;
        e1.AppendChild(e2);
        doc.DocumentElement.AppendChild(e1);
        doc.Save(@"staticdata\diseases.xml");
        result.Text = txtName.Text + " was added to the list.<br> Add More: ";
        result.Visible = true;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (rdoAddDisease.Checked == true)
        {
            addDisease();
        }

        if (rdoAddMedicine.Checked == true)
        {
            addMedicine();
        }
    }
    protected void AdminDoctorView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Datakey is retrieved using AdminDoctorView.DataKeys[0].Value
        BusinessLayer businessLyerObj = new BusinessLayer();
        string connectString = ConfigurationManager.AppSettings.Get("connString");
        int index = e.RowIndex + (AdminDoctorView.PageIndex * 10);
        businessLyerObj.DeleteDoctor(AdminDoctorView.DataKeys[index].Value.ToString(), connectString);

    }
    protected void AdminDoctorView_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        BusinessLayer businessLyerObj = new BusinessLayer();
        string connectString = ConfigurationManager.AppSettings.Get("connString");
        int index = e.RowIndex;
        businessLyerObj.ApproveDoctor(AdminDoctorView.DataKeys[index].Value.ToString(), connectString);
    }
    protected void AdminUserView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Datakey is retrieved using AdminDoctorView.DataKeys[0].Value
        BusinessLayer businessLyerObj = new BusinessLayer();
        string connectString = ConfigurationManager.AppSettings.Get("connString");
        int index = e.RowIndex + (AdminUserView.PageIndex * 4);
        businessLyerObj.DeleteUser(AdminUserView.DataKeys[index].Value.ToString(), connectString);

    }
    protected void AdminDoctorView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        AdminDoctorView.PageIndex = e.NewPageIndex;
        AdminDoctorView.DataBind();
    }
    protected void AdminUserView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        AdminUserView.PageIndex = e.NewPageIndex;
        AdminUserView.DataBind();
    }


    
}
