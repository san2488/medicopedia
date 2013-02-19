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

public partial class ctrlLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void butLogin_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        //Response.Redirect("Links.aspx");
        AuthTable user = new AuthTable();
        user.Username = txtUsername.Text;
        if (txtUsername.Text!="Admin")
        {
            user.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");
        }
        else
        {
            user.Password = txtPassword.Text;
        }
        BusinessLayer businessLayerObj = new BusinessLayer();
        bool isRegistered = businessLayerObj.IsRegisteredUser(user, connectionString);

        if (isRegistered)
        {
            Session["Username"] = user.Username;
            Session["SignedIn"] = true;
            user.Role = businessLayerObj.GetUser(user, connectionString).Role;
            Session["Role"] = user.Role;
            FormsAuthentication.RedirectFromLoginPage(user.Username, false);
            //Response.Redirect("index.aspx");
            //if (Session["Role"].ToString() == "0")
            //{
            //    Response.Redirect("UserHome.aspx");
            //}
            //else if (Session["Role"].ToString() == "1")
            //{
            //    Response.Redirect("DoctorHome.aspx");
            //}
            //else if (Session["Role"].ToString() == "2")
            //{
            //    Response.Redirect("AdminHome.aspx");
            //}
        }
    }
}
