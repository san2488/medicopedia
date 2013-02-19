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
using DomainClassLayer;
using BusinessClassLayer;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        PlaceHolder2.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string message = SaveAdvice();

        if(message.Equals("noerror"))
        {
            PlaceHolder1.Visible=false;
            PlaceHolder2.Visible=true;
            return;
        }

        lblErrorMsg.Text=message;

    }

    public string SaveAdvice()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Advice adviceObj = new Advice();

        //creating an advice object
        adviceObj.QueryId = Convert.ToInt32(Request.QueryString["QueryId"]);

        adviceObj.Username = Session["Username"].ToString() ;

        adviceObj.Likes = 0;

        adviceObj.Dislikes = 0;

        adviceObj.AdviceTitle = txtAdviceTitle.Text;

        adviceObj.AdviceDescription = txtAdvice.Text;

        adviceObj.AdviceDateTime = DateTime.Now;


        //inserting data through business layer
        BusinessLayer businessLayerObj = new BusinessLayer();

        try
        {
            businessLayerObj.InsertAdvice(adviceObj, connectionString);
        }
        catch(Exception ex)
        {
            return ex.Message;
        }

        return "noerror";
    }
}
