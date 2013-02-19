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
using System.Data.SqlClient;
using BusinessClassLayer;
using DomainClassLayer;

public partial class WebUserControl : System.Web.UI.UserControl
{
    private enum Role
    {
        User,
        Doctor,
        Admin
    };
    private int percentageWidth;
    public int PercentageWidth
    {
        get { return percentageWidth; }
        set { percentageWidth = value; }
    }

    private string destination = "index.aspx";
    public string Destination
    {
        get { return destination; }
        set { destination = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dsInterest = new DataSet();
        dsInterest.ReadXml(MapPath("staticdata/diseases.xml"));
        ddlInterestList.DataSource = dsInterest;
        ddlInterestList.DataTextField = "name";
        ddlInterestList.DataValueField = "name";
        ddlInterestList.DataBind();
    }
    protected void butSubmit_Click(object sender, EventArgs e)
    {
        string connString = ConfigurationManager.AppSettings.Get("connString");
        BusinessLayer bussinessLayerObj = new BusinessLayer();
        AuthTable authUser = new AuthTable();

        if (txtPassword.Text.Trim() != string.Empty)
        {
            authUser.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");
        }
        else
        {
            authUser.Password = txtPassword.Text.Trim();
        }
        
        if (cblIsDoctor.SelectedValue!="true")
        {
            authUser.Role = (int)Role.User;
            Users user = new Users();
            user.Username = txtUsername.Text.Trim();
            authUser.Username = txtUsername.Text.Trim();
            user.UserFullName = txtUserFullName.Text.Trim();
            DateTime dob;
            user.UserDOB = !DateTime.TryParse(txtDoB.Value, out dob) ? null : (DateTime?)DateTime.Parse(txtDoB.Value); 
            user.UserGender = bool.Parse(rblGender.SelectedValue);
            user.UserEmailId = txtEmailId.Text.Trim();
            user.UserAreaOfInterest = ddlInterestList.SelectedValue;
            try
            {
                bussinessLayerObj.InsertUsers(user, authUser, connString);
                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                lblErrors.Text = ex.Message;
            }
        }
        else
        {
            authUser.Role = (int)Role.Doctor;
            Doctor doctor = new Doctor();
            doctor.DocName = txtUserFullName.Text.Trim();
            doctor.Username = txtUsername.Text.Trim();
            authUser.Username = txtUsername.Text.Trim();
            DateTime dob;
            doctor.DocDateOfBirth = !DateTime.TryParse(txtDoB.Value, out dob) ? null : (DateTime?)DateTime.Parse(txtDoB.Value); 
            doctor.DocGender = bool.Parse(rblGender.SelectedValue);
            doctor.DocEmailId = txtEmailId.Text.Trim();
            doctor.DocAreaOfInterest = ddlInterestList.SelectedValue;
            doctor.DocIsApproved = false;
            doctor.DocLicenseNo = int.Parse(txtLicNo.Text.Trim());
            try
            {
                bussinessLayerObj.InsertDoctor(doctor, authUser, connString);
                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                lblErrors.Text = ex.Message;
            }
        }
    }
    protected void cblIsDoctor_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cblIsDoctor.SelectedValue == "true")
        {
            txtLicNo.Enabled = true;
        }
        else
        {
            txtLicNo.Enabled = false;
        }
    }
}
